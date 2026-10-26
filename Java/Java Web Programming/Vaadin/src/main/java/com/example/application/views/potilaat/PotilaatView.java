package com.example.application.views.potilaat;

import com.example.application.data.entity.Persons;
import com.example.application.data.service.PersonsService;
import com.example.application.views.MainLayout;
import com.vaadin.flow.component.UI;
import com.vaadin.flow.component.button.Button;
import com.vaadin.flow.component.button.ButtonVariant;
import com.vaadin.flow.component.datepicker.DatePicker;
import com.vaadin.flow.component.formlayout.FormLayout;
import com.vaadin.flow.component.grid.Grid;
import com.vaadin.flow.component.grid.GridVariant;
import com.vaadin.flow.component.html.Div;
import com.vaadin.flow.component.notification.Notification;
import com.vaadin.flow.component.notification.Notification.Position;
import com.vaadin.flow.component.notification.NotificationVariant;
import com.vaadin.flow.component.orderedlayout.HorizontalLayout;
import com.vaadin.flow.component.splitlayout.SplitLayout;
import com.vaadin.flow.component.textfield.TextField;
import com.vaadin.flow.data.binder.BeanValidationBinder;
import com.vaadin.flow.data.binder.ValidationException;
import com.vaadin.flow.data.converter.StringToIntegerConverter;
import com.vaadin.flow.router.BeforeEnterEvent;
import com.vaadin.flow.router.BeforeEnterObserver;
import com.vaadin.flow.router.PageTitle;
import com.vaadin.flow.router.Route;
import com.vaadin.flow.spring.data.VaadinSpringDataHelpers;
import jakarta.annotation.security.PermitAll;
import java.util.Optional;
import org.springframework.data.domain.PageRequest;
import org.springframework.orm.ObjectOptimisticLockingFailureException;

@PageTitle("Potilaat")
@Route(value = "potilaat/:personsID?/:action?(edit)", layout = MainLayout.class)
@PermitAll
public class PotilaatView extends Div implements BeforeEnterObserver {

    private final String PERSONS_ID = "personsID";
    private final String PERSONS_EDIT_ROUTE_TEMPLATE = "potilaat/%s/edit";

    private final Grid<Persons> grid = new Grid<>(Persons.class, false);

    private TextField personid;
    private TextField etunimi;
    private TextField sukunimi;
    private TextField email;
    private TextField puh;
    private DatePicker syntymaaika;

    private final Button cancel = new Button("Cancel");
    private final Button save = new Button("Save");
    private final Button delete = new Button("Delete");
    private final BeanValidationBinder<Persons> binder;

    private Persons persons;

    private final PersonsService personsService;

    public PotilaatView(PersonsService personsService) {
        this.personsService = personsService;
        addClassNames("potilaat-view");

        // Create UI
        SplitLayout splitLayout = new SplitLayout();

        createGridLayout(splitLayout);
        createEditorLayout(splitLayout);

        add(splitLayout);

        // Configure Grid
        grid.addColumn("personid").setAutoWidth(true);
        grid.addColumn("etunimi").setAutoWidth(true);
        grid.addColumn("sukunimi").setAutoWidth(true);
        grid.addColumn("email").setAutoWidth(true);
        grid.addColumn("puh").setAutoWidth(true);
        grid.addColumn("syntymaaika").setAutoWidth(true);
        grid.setItems(query -> personsService.list(
                PageRequest.of(query.getPage(), query.getPageSize(), VaadinSpringDataHelpers.toSpringDataSort(query)))
                .stream());
        grid.addThemeVariants(GridVariant.LUMO_NO_BORDER);

        // when a row is selected or deselected, populate form
        grid.asSingleSelect().addValueChangeListener(event -> {
            if (event.getValue() != null) {
                UI.getCurrent().navigate(String.format(PERSONS_EDIT_ROUTE_TEMPLATE, event.getValue().getId()));
            } else {
                clearForm();
                UI.getCurrent().navigate(PotilaatView.class);
            }
        });

        // Configure Form
        binder = new BeanValidationBinder<>(Persons.class);

        // Bind fields. This is where you'd define e.g. validation rules
        binder.forField(personid).withConverter(new StringToIntegerConverter("Only numbers are allowed"))
                .bind("personid");

        binder.bindInstanceFields(this);

        cancel.addClickListener(e -> {
            clearForm();
            refreshGrid();
        });

        save.addClickListener(e -> {
            try {
                if (this.persons == null) {
                    this.persons = new Persons();
                }
                binder.writeBean(this.persons);
                personsService.update(this.persons);
                clearForm();
                refreshGrid();
                Notification.show("Data updated");
                UI.getCurrent().navigate(PotilaatView.class);
            } catch (ObjectOptimisticLockingFailureException exception) {
                Notification n = Notification.show(
                        "Error updating the data. Somebody else has updated the record while you were making changes.");
                n.setPosition(Position.MIDDLE);
                n.addThemeVariants(NotificationVariant.LUMO_ERROR);
            } catch (ValidationException validationException) {
                Notification.show("Failed to update the data. Check again that all values are valid");
            }
        });
        delete.addClickListener(e -> {
            if (this.persons != null) {
                personsService.delete(this.persons);
                clearForm();
                refreshGrid();
                Notification.show("Data deleted");
                UI.getCurrent().navigate(PotilaatView.class);
            }
        });
    }

    @Override
    public void beforeEnter(BeforeEnterEvent event) {
        Optional<Long> personsId = event.getRouteParameters().get(PERSONS_ID).map(Long::parseLong);
        if (personsId.isPresent()) {
            Optional<Persons> personsFromBackend = personsService.get(personsId.get());
            if (personsFromBackend.isPresent()) {
                populateForm(personsFromBackend.get());
            } else {
                Notification.show(String.format("The requested persons was not found, ID = %s", personsId.get()), 3000,
                        Notification.Position.BOTTOM_START);
                // when a row is selected but the data is no longer available,
                // refresh grid
                refreshGrid();
                event.forwardTo(PotilaatView.class);
            }
        }
    }

    private void createEditorLayout(SplitLayout splitLayout) {
        Div editorLayoutDiv = new Div();
        editorLayoutDiv.setClassName("editor-layout");

        Div editorDiv = new Div();
        editorDiv.setClassName("editor");
        editorLayoutDiv.add(editorDiv);

        FormLayout formLayout = new FormLayout();
        personid = new TextField("Personid");
        etunimi = new TextField("Etunimi");
        sukunimi = new TextField("Sukunimi");
        email = new TextField("Email");
        puh = new TextField("Puh");
        syntymaaika = new DatePicker("Syntymaaika");
        formLayout.add(personid, etunimi, sukunimi, email, puh, syntymaaika);

        editorDiv.add(formLayout);
        createButtonLayout(editorLayoutDiv);

        splitLayout.addToSecondary(editorLayoutDiv);
    }

    private void createButtonLayout(Div editorLayoutDiv) {
        HorizontalLayout buttonLayout = new HorizontalLayout();
        buttonLayout.setClassName("button-layout");
        cancel.addThemeVariants(ButtonVariant.LUMO_TERTIARY);
        save.addThemeVariants(ButtonVariant.LUMO_PRIMARY);
        buttonLayout.add(save, cancel,delete);
        editorLayoutDiv.add(buttonLayout);
    }

    private void createGridLayout(SplitLayout splitLayout) {
        Div wrapper = new Div();
        wrapper.setClassName("grid-wrapper");
        splitLayout.addToPrimary(wrapper);
        wrapper.add(grid);
    }

    private void refreshGrid() {
        grid.select(null);
        grid.getDataProvider().refreshAll();
    }

    private void clearForm() {
        populateForm(null);
    }

    private void populateForm(Persons value) {
        this.persons = value;
        binder.readBean(this.persons);

    }
}

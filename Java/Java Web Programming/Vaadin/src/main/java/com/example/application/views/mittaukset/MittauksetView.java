package com.example.application.views.mittaukset;

import com.example.application.data.entity.Mittaukset;
import com.example.application.data.service.MittauksetService;
import com.example.application.views.MainLayout;
import com.example.application.views.potilaat.PotilaatView;
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
import com.vaadin.flow.router.RouteAlias;
import com.vaadin.flow.spring.data.VaadinSpringDataHelpers;
import jakarta.annotation.security.PermitAll;
import java.util.Optional;
import org.springframework.data.domain.PageRequest;
import org.springframework.orm.ObjectOptimisticLockingFailureException;

@PageTitle("Mittaukset")
@Route(value = "mittaukset/:mittauksetID?/:action?(edit)", layout = MainLayout.class)
@RouteAlias(value = "", layout = MainLayout.class)
@PermitAll
public class MittauksetView extends Div implements BeforeEnterObserver {

    private final String MITTAUKSET_ID = "mittauksetID";
    private final String MITTAUKSET_EDIT_ROUTE_TEMPLATE = "mittaukset/%s/edit";

    private final Grid<Mittaukset> grid = new Grid<>(Mittaukset.class, false);

    private TextField personid;
    private TextField mittausid;
    private TextField paino;
    private TextField pituus;
    private TextField verenpaine;
    private TextField syke;
    private TextField verensokeri;
    private DatePicker mittauspvm;

    private final Button cancel = new Button("Cancel");
    private final Button save = new Button("Save");
    private final Button delete = new Button("Delete");
    private final BeanValidationBinder<Mittaukset> binder;

    private Mittaukset mittaukset;

    private final MittauksetService mittauksetService;

    public MittauksetView(MittauksetService mittauksetService) {
        this.mittauksetService = mittauksetService;
        addClassNames("mittaukset-view");

        // Create UI
        SplitLayout splitLayout = new SplitLayout();

        createGridLayout(splitLayout);
        createEditorLayout(splitLayout);

        add(splitLayout);

        // Configure Grid
        grid.addColumn("personid").setAutoWidth(true);
        grid.addColumn("mittausid").setAutoWidth(true);
        grid.addColumn("paino").setAutoWidth(true);
        grid.addColumn("pituus").setAutoWidth(true);
        grid.addColumn("verenpaine").setAutoWidth(true);
        grid.addColumn("syke").setAutoWidth(true);
        grid.addColumn("verensokeri").setAutoWidth(true);
        grid.addColumn("mittauspvm").setAutoWidth(true);
        grid.setItems(query -> mittauksetService.list(
                PageRequest.of(query.getPage(), query.getPageSize(), VaadinSpringDataHelpers.toSpringDataSort(query)))
                .stream());
        grid.addThemeVariants(GridVariant.LUMO_NO_BORDER);

        // when a row is selected or deselected, populate form
        grid.asSingleSelect().addValueChangeListener(event -> {
            if (event.getValue() != null) {
                UI.getCurrent().navigate(String.format(MITTAUKSET_EDIT_ROUTE_TEMPLATE, event.getValue().getId()));
            } else {
                clearForm();
                UI.getCurrent().navigate(MittauksetView.class);
            }
        });

        // Configure Form
        binder = new BeanValidationBinder<>(Mittaukset.class);

        // Bind fields. This is where you'd define e.g. validation rules
        binder.forField(personid).withConverter(new StringToIntegerConverter("Only numbers are allowed"))
                .bind("personid");
        binder.forField(mittausid).withConverter(new StringToIntegerConverter("Only numbers are allowed"))
                .bind("mittausid");
        binder.forField(paino).withConverter(new StringToIntegerConverter("Only numbers are allowed")).bind("paino");
        binder.forField(pituus).withConverter(new StringToIntegerConverter("Only numbers are allowed")).bind("pituus");
        binder.forField(verenpaine).withConverter(new StringToIntegerConverter("Only numbers are allowed"))
                .bind("verenpaine");
        binder.forField(syke).withConverter(new StringToIntegerConverter("Only numbers are allowed")).bind("syke");
        binder.forField(verensokeri).withConverter(new StringToIntegerConverter("Only numbers are allowed"))
                .bind("verensokeri");

        binder.bindInstanceFields(this);

        cancel.addClickListener(e -> {
            clearForm();
            refreshGrid();
        });

        save.addClickListener(e -> {
            try {
                if (this.mittaukset == null) {
                    this.mittaukset = new Mittaukset();
                }
                binder.writeBean(this.mittaukset);
                mittauksetService.update(this.mittaukset);
                clearForm();
                refreshGrid();
                Notification.show("Data updated");
                UI.getCurrent().navigate(MittauksetView.class);
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
            if (this.mittaukset != null) {
                mittauksetService.delete(this.mittaukset);
                clearForm();
                refreshGrid();
                Notification.show("Data deleted");
                UI.getCurrent().navigate(MittauksetView.class);
            }
        });
    }

    @Override
    public void beforeEnter(BeforeEnterEvent event) {
        Optional<Long> mittauksetId = event.getRouteParameters().get(MITTAUKSET_ID).map(Long::parseLong);
        if (mittauksetId.isPresent()) {
            Optional<Mittaukset> mittauksetFromBackend = mittauksetService.get(mittauksetId.get());
            if (mittauksetFromBackend.isPresent()) {
                populateForm(mittauksetFromBackend.get());
            } else {
                Notification.show(String.format("The requested mittaukset was not found, ID = %s", mittauksetId.get()),
                        3000, Notification.Position.BOTTOM_START);
                // when a row is selected but the data is no longer available,
                // refresh grid
                refreshGrid();
                event.forwardTo(MittauksetView.class);
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
        mittausid = new TextField("Mittausid");
        paino = new TextField("Paino");
        pituus = new TextField("Pituus");
        verenpaine = new TextField("Verenpaine");
        syke = new TextField("Syke");
        verensokeri = new TextField("Verensokeri");
        mittauspvm = new DatePicker("Mittauspvm");
        formLayout.add(personid, mittausid, paino, pituus, verenpaine, syke, verensokeri, mittauspvm);

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

    private void populateForm(Mittaukset value) {
        this.mittaukset = value;
        binder.readBean(this.mittaukset);

    }
}

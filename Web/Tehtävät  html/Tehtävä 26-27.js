function tarkista() {
    var nimi = document.getElementById("nimi");
    var osoite = document.getElementById("osoite");


    if (nimi.value == "") {
        nimi.style.backgroundColor = "red";
    }

    if (osoite.value == "") {

        osoite.style.backgroundColor = "red";

    }
    else if (osoite.value != "" && nimi.value != "") {
        nimi.style.backgroundColor = "white";
        osoite.style.backgroundColor = "white";
        lisaa()
    }
    function lisaa() {
        var table = document.getElementById('taulu');
        var nextIndex = table.childNodes.length;
        var newRow = document.createElement("TR");
        var firstCell = document.createElement("TD");
        var firstCellTextarea = document.createElement("TEXTAREA");
        var secondCell = document.createElement("TD");
        var secondCellTextarea = document.createElement("TEXTAREA");

        firstCellTextarea.setAttribute("id", "question" + nextIndex);
        firstCellTextarea.setAttribute("name", "Question + nextIndex");
        firstCellTextarea.setAttribute("placeholder", nimi.value);
        firstCellTextarea.setAttribute("th:field", "${questionAnswerSet.question}");
        firstCellTextarea.setAttribute("style", "resize: none; width: 100%;");

        secondCellTextarea.setAttribute("id", "answer" + nextIndex);
        secondCellTextarea.setAttribute("name", "Answer + nextIndex");
        secondCellTextarea.setAttribute("placeholder", osoite.value);
        secondCellTextarea.setAttribute("th:field", "${questionAnswerSet.answer}");
        secondCellTextarea.setAttribute("style", "resize: none; width: 100%;");

        firstCell.appendChild(firstCellTextarea);
        secondCell.appendChild(secondCellTextarea);

        newRow.appendChild(firstCell);
        newRow.appendChild(secondCell);

        table.appendChild(newRow);
        nimi.value = "";
        osoite.value = "";
    }
}
var lang = $("html").attr("lang");
var finnish = '<option value="0">' + "Kaikki" + '</option>';
var english = '<option value="0">' + "All" + '</option>';
var language = '';
var x = 1;
var pvm;
$(document).ready(function () {
    var customertypes = [];
    $.get("http://animalhospital.freemyip.com/customerbase/Types", function (data, status) {
        customertypes = data;
        $.each(customertypes, function (index) {
            finnish += '<option value="' + this.customertypeid + '">' + this.description_fi + '</option>';
            english += '<option value="' + this.customertypeid + '">' + this.description_en + '</option>';
        });
        language = finnish;
        $('#customertype').append(language);
        $("#fetchData").click();
    })

    $("#fetchData").click(function () {
        {
            var url = new URL('http://animalhospital.freemyip.com/customerbase/Customer?');
            var idpara; var namepara;
            var address = $('#address').val();
            var customerid = $('#customerid').val();
            var customertype = $('#customertype').val();
            var name = $('#name').val();
            var postalnumber = $('#postalnumber').val();
            var postaloffice = $('#postaloffice').val();

            //LisÃ¤tÃ¤Ã¤n parametrit kentistÃ¤, mitkÃ¤ ovat tÃ¤ytetty
            if ($('#customerid').val() > '') {
                var idparams = "customerid=" + customerid + "&";
                url += idparams;
            }
            if ($('#name').val() > '') {
                var namepara = "name=" + name + "&";
                url += namepara;
            }
            if ($('#address').val() > '') {
                var addresspara = "address=" + address + "&";
                url += addresspara;
            }
            if ($('#postalnumber').val() > '') {
                var postalnumberpara = "postalnumber=" + postalnumber + "&";
                url += postalnumberpara;
            }
            if ($('#postaloffice').val() > '') {
                var postalofficepara = "postaloffice=" + postaloffice + "&";
                url += postalofficepara;
            }
            if ($('#customertype').val() > 0) {
                var customertypepara = "customertype=" + customertype + "&";
                url += customertypepara;
            }

        }
        $("#taulu").empty();

        $.get(url,
            function (data, status) {

                data.map((customer) => {
                    var addStr = "";
                    for (var key of Object.keys(customer)) {
                        for (const [key, value] of Object.entries(customer)) {
                            if (key == "customerid") {
                                x = value; //otetaan customerid talteen, ja lisätään se nappulan iideehen.
                            }
                        }
                        if (key == "customertype") {
                            for (var type of customertypes)
                                if (type.customertypeid == customer[key])
                                    addStr += "<td>" + type["description_" + lang] + "</td>" + '<td><button id="' + x + '"class="muokkaa">Edit</button></td>'
                                        + "</td>" + '<td><button id="' + x + '"class="poisto">Delete</button></td>'//Lisätään nappula mukaan, nappulan id = customerid
                                        ;//sama homma, mutta muokkausmielessä.
                        }
                        else
                            addStr += "<td>" + customer[key] + "</td>";
                        ;
                    }
                    $("#taulu").append("<tr>" + addStr + "</tr>");
                })
            }).fail((jqXHR) => {
                console.log(jqXHR);
            })
    })
    //Kielenvalinnanvaikutkset
    $("input[name='lang']").change(function () {
        if ($('#fin').is(':checked')) {
            lang = "fi";
            $('#customertype').find('option').remove().end().append(finnish);
            $("#fintext").html("Suomeksi");
            $("#engtext").html("In English");
            $("#fetchData").html("Hae tiedot");
            $("#idtext").text("Id");
            $("#nametext").text("Nimi");
            $("#addresstext").text("Osoite");
            $("#postalnumbertext").text("Postinumero");
            $("#postalaretext").text("Postitoimipaikka");
            $("#createddatetext").text("LuontipÃ¤ivÃ¤");
            $("#customertypetext").text("Asiakastyyppi");
            $("#addC").text("LisÃ¤Ã¤ asiakas");
            $("#removeC").text("Poista asiakas");
            $("#editC").text("Muokkaa asiakasta");
            $("#addCustomerLabel").text("LisÃ¤Ã¤ asiakas");
            $("#submitcustomer").text("LisÃ¤Ã¤");
            $("#cancel").text("Perruuta");
            $("#addName").text("Nimi");
            $("#addAdress").text("Osoite");
            $("#addPostalnumber").text("Postinumero");
            $("#addPostalarea").text("Postitoimipaikka");
            $("#first").text("Yritys");
            $("#second").text("Kuluttaja");
            $("#thort").text("RekisterÃ¶ity yhdistys");
            $("#addType").text("Asiakastyyppi");

        }
        if ($('#eng').is(':checked')) {
            lang = "en";
            $('#customertype').find('option').remove().end().append(english);
            $("#fintext").html("In Finnish");
            $("#engtext").html("Englanniksi");
            $("#fetchData").html("Search");
            $("#idtext").text("Id");
            $("#nametext").text("Name");
            $("#addresstext").text("Address");
            $("#postalnumbertext").text("Postalnumer");
            $("#postalaretext").text("Postalarea");
            $("#createddatetext").text("Created");
            $("#customertypetext").text("Customer type");
            $("#addC").text("Add customer");
            $("#removeC").text("Remove customer");
            $("#addCustomerLabel").text("Add customer");
            $("#editC").text("Edit customer");
            $("#submitcustomer").text("Submit");
            $("#cancel").text("Cancel");
            $("#addName").text("Name");
            $("#addAdress").text("Address");
            $("#addPostalnumber").text("Postal number");
            $("#addPostalarea").text("Postal area");
            $("#first").text("Company");
            $("#second").text("Consumer");
            $("#thort").text("Registered association");
            $("#addType").text("Customer type");
            $("#addType").text("Customer type");
        }
    });

    pvm = new Date();
    document.getElementById("screateddate").value = pvm;
    //POISTO
    $(document).on('click', '.poisto', function () {
        $.ajax({
            type: 'DELETE',
            url: 'http://animalhospital.freemyip.com/customerbase/Customer/' + this.id,//painetun nappulan idee = customerid
            success: function () {
                location.reload();
            },
            error: function () {
                console.log("Virhe");
            }
        })
    });

    //MUOKKAUS
    $(document).on('click', '.muokkaa', function () {
        var eurl = new URL('http://animalhospital.freemyip.com/customerbase/Customer/');
        eurl += this.id;
        thisid = this.id
        $("#editCustomer").modal();
        $.get(eurl, function (data, status) {
            data.map((customer) => {
                for (var key of Object.keys(customer)) {
                    for (const [key, value] of Object.entries(customer)) {
                        if (key == "customerid") {
                            document.getElementById("ecustomerid").value = customer.customerid;
                            document.getElementById("ename").value = customer.name;
                            document.getElementById("eaddress").value = customer.address;
                            document.getElementById("epostalnumber").value = customer.postalnumber;
                            document.getElementById("epostaloffice").value = customer.postaloffice;
                            document.getElementById("ecreateddate").value = customer.createddate;
                            document.getElementById("eaddcustomertype").value = customer.customertype;
                        }
                    }
                }
            })
        });
        console.log("painettu: " + this.id);

        $("#ecustom").on('click', (function () {

            var muokattu =
            {
                customerid: $("#ecustomerid").val(),
                name: $("#ename").val(),
                address: $("#eaddress").val(),
                postalnumber: $("#epostalnumber").val(),
                postaloffice: $("#epostaloffice").val(),

                customertype: $("#eaddcustomertype").val()
            };

            $.ajax({

                method: "PUT",
                url: eurl,
                data: muokattu,

            });

            alert('Asiakas muokattu');

        }));


    });
    //LISÄÄ
    $(function () {

        $("#submitcustomer").on('click', (function () {

            var lahetys =
            {
                customerid: $("#scustomerId").val(),
                name: $("#sname").val(),
                address: $("#saddress").val(),
                postalnumber: $("#spostalnumber").val(),
                postaloffice: $("#spostaloffice").val(),
                creteddate: $("#screateddate").val(),
                customertype: $("#saddcustomerType").val()

            };
            $.ajax({
                type: "POST",
                url: "http://animalhospital.freemyip.com/customerbase/Customer?",
                data: lahetys,
                success: function () {
                    alert('Asiakas lisÃ¤tty');

                },
                error: function () {
                    alert("Virhe");
                }
            });

        }));

    });

});
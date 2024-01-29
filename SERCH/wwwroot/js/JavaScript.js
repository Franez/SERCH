$(document).ready(function () {
    $("procesarBtn").click(function () {
        var inputText = $("#inputRelato").val();
        $ajax({
            type: "POST",
            url: ,//DEJAR URL DE FUNCION
            data: { relato: inputText, condicion: selectedCondition },
            success: function (data) {
                $("#resultadoRelato").html(data);

            }
            error: function () {
                alert("Hubo un error al porocesar el relato");
            }
        });
    });
});
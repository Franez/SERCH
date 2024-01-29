$(document).ready(function () {
    $("#btnBuscar").click(function () { // Corregir el selector
        var inputText = $("#boxBuscar").val(); // Usar el ID correcto para el input de relato
        var selectedCondition = $("#condicion").val();
        $.ajax({
            type: "POST",
            url: "URL_AQUI",
            data: { relato: inputText, condicion: selectedCondition },
            success: function (data) {
                $("#resultadoRelato").html(data);
            },
            error: function (xhr, status, error) {
                console.error("Error en la solicitud AJAX:", status, error);
                alert("Hubo un error al procesar el relato");
            }
        });
    });
});

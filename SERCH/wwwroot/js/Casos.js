//Declaracion Variables Globales
let camposMax = 10; //MAXIMO 10 Palabras
let numCampos = 0;
let indicePalabra = 0;
let indiceOperador = 0;

let palabras = [];
let operadores = [];

let lblQuery = "";
var currentAjaxRequest;

$(document).ready(function () {

    let RelatosIndex = $('#RelatosIndex').DataTable({
        "language": {
            "url": "/lib/datatables/def_tabla.json"
        },
        "paging": true,
        "lengthChange": false,
        "searching": true,
        "ordering": false,
        "info": true,
        "autoWidth": false,
        "responsive": true
    });


    //#region Loader
    $(document).ajaxStart(function () {
        $('.loading-screen').show();
    });
    $(document).ajaxStop(function () {
        $('.loading-screen').hide();
    });
    //#region Loader

    //#region inputsDinamicos
    
    $('#add_Word').click(function (e) {
        e.preventDefault();

        if (numCampos < camposMax && indiceOperador < 10) {

            var palabraBusqueda = $("#boxBuscar").val(); // Obtener el valor del input
            var etiquetaPalabras = $("#etiquetaPalabras");

            if (etiquetaPalabras.text() === "" && palabraBusqueda != "") {
                // Si el contenido de la etiqueta es vacío, asigna una consulta SQL inicial
                etiquetaPalabras.text("SELECT InpFolio, InpRelatoHecho FROM inp_caso WHERE CONTAINS(InpRelatoHecho,");

                if (palabraBusqueda !== "") {
                    // Si palabraBusqueda no está vacía, agrega la palabra al contenido de la etiqueta
                    var palabrasActuales = etiquetaPalabras.text();

                    if (palabraBusqueda.indexOf(" ") !== -1) {
                        etiquetaPalabras.html(palabrasActuales + "'" + '"' + "<span style='color: red'>" + palabraBusqueda + "</span>" + '"' + "' " + ")"); //comillas dobles para palabras con espacio
                    } else {

                        etiquetaPalabras.html(palabrasActuales + "'" + "<span style='color: red'>" + palabraBusqueda + "</span>" + "' " + ")"); //comillas simple para palabras sin espacio

                    }
                    
                    // Borrar el contenido del input
                    $("#boxBuscar").val("");

                    // Almacenar el valor completo del label en una variable
                    var palabrasCompletas = etiquetaPalabras.text();

                    console.log("Palabras completas: " + palabrasCompletas);
                } else {
                    console.log("Se debe agregar una palabra de búsqueda.");
                }

                document.getElementById('add_Word').style.display = 'none';
                document.getElementById('add_And').style.display = 'inline-block';
                document.getElementById('add_Or').style.display = 'inline-block';
                document.getElementById('addParentesisInicio').style.display = 'inline-block';
                document.getElementById('addParentesisFinal').style.display = 'inline-block';
                document.getElementById('LimpiarQuery').style.display = 'inline-block';
                document.getElementById('btnBuscar').style.display = 'inline-block';

                document.getElementById('add_And_E').style.display = 'inline-block';
                document.getElementById('add_Or_E').style.display = 'inline-block';

            } else {

                if (palabraBusqueda !== "") {
                    // Si palabraBusqueda no está vacía, agrega la palabra al contenido de la etiqueta
                    var palabrasActuales = etiquetaPalabras.text();
                    // Almacenar el valor completo del label en una variable
                    var palabrasCompletas = etiquetaPalabras.text();
                    console.log("Palabras completas: " + palabrasCompletas);

                    indicePalabra++;
                    numCampos++;

                    document.getElementById('add_Word').style.display = 'none';
                    document.getElementById('add_And').style.display = 'inline-block';
                    document.getElementById('add_Or').style.display = 'inline-block';
                    document.getElementById('addParentesisInicio').style.display = 'inline-block';
                    document.getElementById('addParentesisFinal').style.display = 'inline-block';
                    document.getElementById('LimpiarQuery').style.display = 'inline-block';
                    document.getElementById('btnBuscar').style.display = 'inline-block';

                    document.getElementById('add_And_E').style.display = 'inline-block';
                    document.getElementById('add_Or_E').style.display = 'inline-block';

                } else {
                    alert("Se debe agregar una palabra de búsqueda.");
                }

            }

            // Incrementar el índice para el próximo elemento
            

        } else {
            alert("PEEENCA");
            console.log("SE ALCANZO EL NUMERO MAXIMO DE PALABRAS POR AGREGAR")
        }

        palabras.push(palabraBusqueda);

    });

    //Boton and
   $('#add_And').click(function (e) {
        e.preventDefault();
        if (numCampos < camposMax && indiceOperador < 10) {
            var palabraBusqueda = $("#boxBuscar").val();
            var etiquetaPalabras = $("#etiquetaPalabras");
            
            if (palabraBusqueda.includes(" ")) {
                if (palabraBusqueda !== "") {
                    etiquetaPalabras.html(etiquetaPalabras.html() + " AND CONTAINS(InpRelatoHecho," + "'" + '"' + "<span style='color: red'>" + palabraBusqueda + "</span>" + '"' + "' " + ")");
                    $("#boxBuscar").val("");

                    var palabrasCompletas = etiquetaPalabras.text();
                    console.log("Palabras completas: " + palabrasCompletas);
                } else {
                    alert("Se debe agregar una palabra");
                    console.log("Se debe agregar una palabra de búsqueda.");
                }
            } else {
                if (palabraBusqueda !== "") {
                    etiquetaPalabras.html(etiquetaPalabras.html() + " AND CONTAINS(InpRelatoHecho, '<span style='color: red'>" + palabraBusqueda + "</span>')");
                    $("#boxBuscar").val("");

                    var palabrasCompletas = etiquetaPalabras.text();
                    console.log("Palabras completas: " + palabrasCompletas);
                } else {
                    alert("Se debe agregar una palabra");
                    console.log("Se debe agregar una palabra de búsqueda.");
                }
            }

        
            indicePalabra++;
            indiceOperador++;
            numCampos++;

            operadores.push('AND');
            palabras.push(palabraBusqueda);
        } else {
            alert("limite alcanzado, SE ALCANZO EL NUMERO MAXIMO DE PALABRAS POR AGREGAR");
            console.log("SE ALCANZO EL NUMERO MAXIMO DE PALABRAS POR AGREGAR");
        }
    });

    //Boton OR

    $('#add_Or').click(function (e) {
        e.preventDefault();
        if (numCampos < camposMax && indiceOperador < 10) {
            var palabraBusqueda = $("#boxBuscar").val();
            var etiquetaPalabras = $("#etiquetaPalabras");

            if (palabraBusqueda.includes(" ")) {
                if (palabraBusqueda !== "") {
                    //etiquetaPalabras.html(etiquetaPalabras.html() + " OR CONTAINS(InpRelatoHecho, '<span style='color: red'>" + palabraBusqueda + "</span>')");
                    etiquetaPalabras.html(etiquetaPalabras.html() + "OR CONTAINS(InpRelatoHecho," + "'" + '"' + "<span style='color: red'>" + palabraBusqueda + "</span>" + '"' + "' " + ")");
                    $("#boxBuscar").val("");

                    var palabrasCompletas = etiquetaPalabras.text();
                    console.log("Palabras completas: " + palabrasCompletas);
                } else {
                    alert("Se debe agregar una palabra");
                    console.log("Se debe agregar una palabra de búsqueda.");
                }
            } else {
                if (palabraBusqueda !== "") {
                    etiquetaPalabras.html(etiquetaPalabras.html() + " OR CONTAINS(InpRelatoHecho, '<span style='color: red'>" + palabraBusqueda + "</span>')");
                    $("#boxBuscar").val("");

                    var palabrasCompletas = etiquetaPalabras.text();
                    console.log("Palabras completas: " + palabrasCompletas);
                } else {
                    alert("Se debe agregar una palabra");
                    console.log("Se debe agregar una palabra de búsqueda.");
                }
            }


            indicePalabra++;
            indiceOperador++;
            numCampos++;

            operadores.push('OR');
            palabras.push(palabraBusqueda);

        } else {
            alert("limite alcanzado, SE ALCANZO EL NUMERO MAXIMO DE PALABRAS POR AGREGAR");
            console.log("SE ALCANZO EL NUMERO MAXIMO DE PALABRAS POR AGREGAR");
        }
    });
    
    //Boton (
    $('#addParentesisInicio').click(function (e) {
        e.preventDefault();

        var etiquetaPalabras = $("#etiquetaPalabras");

        if (etiquetaPalabras.text() === "") {
            console.log("No hay texto para agregar parentesis");
        } else {
            var palabrasActuales = etiquetaPalabras.text();
           etiquetaPalabras.text(palabrasActuales + "(");
        }
        // Almacenar el valor completo del label en una variable
        var palabrasCompletas = etiquetaPalabras.text();

        console.log("Palabras completas: " + palabrasCompletas);
    });
    //Boton )
    $('#addParentesisFinal').click(function (e) {
        e.preventDefault();

        var etiquetaPalabras = $("#etiquetaPalabras");

        if (etiquetaPalabras.text() === "") {
            console.log("no hay texto para agregar parentesis");

        } else {
            var palabrasActuales = etiquetaPalabras.text();
            etiquetaPalabras.text(palabrasActuales + ")");
        }
        // Almacenar el valor completo del label en una variable
        var palabrasCompletas = etiquetaPalabras.text();

        console.log("Palabras completas: " + palabrasCompletas);
    });

    //#region inputsDinamicos

    //#region btnBuscar

    //Boton Buscar
    $('#btnBuscar').on('click', function (e) {
        e.preventDefault();
        lblQuery = $("#etiquetaPalabras").text();
        //let ultimoCaracter = lblQuery.charAt(lblQuery.length - 1);
        //console.log(lblQuery);

    
            // Obtengo el valor del input estatico que está en el html
        let valorInputEstatico = $('#boxBuscar').val();
        console.log("BUSCAR: " + valorInputEstatico);
            palabras.push(valorInputEstatico);

            // Iterar sobre los elementos con la clase 'campo-dinamico' y obtener sus valores
            $('.campo-dinamico .boxBuscar').each(function () {
                const valorInput = $(this).val();
                palabras.push(valorInput);
            });
        console.log("palabras: " + palabras);
        console.log("operadores: " + operadores);

            //let sqlQuery = buildQuery(palabras, operadores);
            let sqlQuery = lblQuery;
            console.log(lblQuery);

        GetRegistros(numCampos, sqlQuery, palabras);
        
    });
    // BOTON LIMPIAR
    $('#LimpiarQuery').on('click', function (e) {
        $('#etiquetaPalabras').text('');

         numCampos = 0;
         indicePalabra = 0;
         indiceOperador = 0;
         palabras = [];
         operadores = [];

        document.getElementById('add_Word').style.display = 'inline-block';
        document.getElementById('add_And').style.display = 'none';
        document.getElementById('add_Or').style.display = 'none';
        document.getElementById('addParentesisInicio').style.display = 'none';
        document.getElementById('addParentesisFinal').style.display = 'none';
        document.getElementById('LimpiarQuery').style.display = 'none';
        document.getElementById('btnBuscar').style.display = 'none';

        document.getElementById('add_And_E').style.display = 'none';
        document.getElementById('add_Or_E').style.display = 'none';
    });

    $('#boxBuscar').on('keydown', function (e) {
        if (e.keyCode == 13) { // 13 es el código de la tecla "Enter"
            e.preventDefault(); // Prevenir el comportamiento predeterminado
            $('#btnBuscar').click(); // Activar el evento de clic en #btnBuscar
        }
    });

    //#region btnBuscar

}); //End Document.ready

// Funcion que construye la query en base a los parametros
function buildQuery(palabras, operadores) {
    if (palabras.length !== operadores.length + 1) {
        throw new Error('Número incorrecto de operadores lógicos en la expresión.');
    }

    const conditions = palabras.map((term) => `CONTAINS(InpRelatoHecho, '"${term}"')`);

    let query = `SELECT InpFolio, InpRelatoHecho FROM inp_caso WHERE ${conditions[0]}`;

    for (let i = 0; i < operadores.length; i++) {
        query += ` ${operadores[i]} ${conditions[i + 1]}`;
    }

    return query;
}

//funcion get registros
function GetRegistros(_count, _query, _palabras) {

    currentAjaxRequest = $.ajax({
        url: '/Casos/BuscarCasos',
        type: "POST",
        cache: false,
        async: true,
        data: {
            query: _query,
            draw: 1,
            start: 0,
            length: _count,
            palabras: _palabras
        },
        success: function (response) {
            if (response.success) {

                let htmlBody = '';
                

                $.each(response.data.result, function (key, value) {

                    let Accion = '<a href="/Casos/Details/' + value.InpFolio + '?palabras=' + encodeURIComponent(palabras) + '" target="_blank">Detalle</a>';

                    // BODY DE LA TABLA
                    htmlBody += '<tr>';
                    htmlBody += '<td>' + value.InpFolio + '</td>';

                    if (value.InpRelatoHecho.length > 250) {
                        // Encontrar el último espacio dentro de los primeros 250 caracteres
                        var espacioAntesDe250 = value.InpRelatoHecho.lastIndexOf(' ', 250);

                        // Recortar el texto hasta el último espacio y agregar "..."
                        if (espacioAntesDe250 !== -1) {
                            htmlBody += '<td>' + value.InpRelatoHecho.substring(0, espacioAntesDe250) + '...</td>';
                        } else {
                            // Si no hay espacio dentro de los primeros 250 caracteres, simplemente cortar en 250
                            htmlBody += '<td>' + value.InpRelatoHecho.substring(0, 250) + '...</td>';
                        }
                    } else {
                        htmlBody += '<td>' + value.InpRelatoHecho + '</td>';
                    }

                    htmlBody += '<td>' + Accion + '</td>';
                    htmlBody += '</tr>';




                });

                if ($.fn.dataTable.isDataTable("#RelatosIndex")) {
                    $("#RelatosIndex").dataTable().fnDestroy();
                    $("#RelatosIndex tbody").html("").append("");
                }

                $("#RelatosIndex tbody").html("").append(htmlBody);




                let RelatosSearch = $('#RelatosIndex').DataTable({
                    "language": {
                        "url": "/lib/datatables/def_tabla.json"
                    },
                    "paging": true,
                    "lengthChange": false,
                    "searching": true,
                    "ordering": false,
                    "info": true,
                    "autoWidth": false,
                    "responsive": true
                });

                $("#RelatosIndex").show();

            }
            else {

                Swal.fire(
                    'Error',
                    response.mensaje,
                    'Pura cachalaca'
                );
            }
        },
        error: function (err) {
            Swal.fire({
                title: "Error",
                type: "error",
                text: "No se pudo procesar su solicitud"
            });
        }
    });

    // boton cancelar carga
    $('#cancelButton').click(function () {
        if (currentAjaxRequest) {
            currentAjaxRequest.abort();
            $('.loading-screen').hide();
        }
        $('#etiquetaPalabras').text('');

        numCampos = 0;
        indicePalabra = 0;
        indiceOperador = 0;
        palabras = [];
        operadores = [];

        document.getElementById('add_Word').style.display = 'inline-block';
        document.getElementById('add_And').style.display = 'none';
        document.getElementById('add_Or').style.display = 'none';
        document.getElementById('addParentesisInicio').style.display = 'none';
        document.getElementById('addParentesisFinal').style.display = 'none';
        document.getElementById('LimpiarQuery').style.display = 'none';
        document.getElementById('btnBuscar').style.display = 'none';
    });
}
//var camposMax = 10;   // Definir la cantidad de campos total
//var numCampos = 0;
//var indicePalabra = 0;
//var indiceOperador = 0;
//var campos = [];

//$('#add_And').click(function (e) {
//    e.preventDefault();
//    agregarCampo('AND');
//});

//$('#add_Or').click(function (e) {
//    e.preventDefault();
//    agregarCampo('OR');
//});

//// Función para agregar un campo con el operador especificado
//function agregarCampo(operador) {
//    if (numCampos < camposMax && numCampos > 0) {
//        // Agregar elementos al contenedor con el índice actual
//        $('#listas').append(
//            '<div class="input-group" id="inputGroup' + indicePalabra + '">' +
//            '<input id="boxBuscar' + indicePalabra + '" class="form-control me-2 tagify" type="search" multiple="multiple" placeholder="Ingrese aquí la palabra clave" aria-label="Search">' +
//            '<button type="button" class="btn btn-danger btn-xs remover_campo" data-indice="' + indicePalabra + '">Remover</button>' +
//            '<input type="hidden" class="operator-selector" value="' + operador + '" data-indice="' + indiceOperador + '">' +
//            '</div>'
//        );

//        // Incrementar el índice para el próximo elemento
//        indicePalabra++;
//        indiceOperador++;
//        numCampos++;
//    } else {
//        console.log("PEEENCAAA")
//    }
//}

//// Remover el div correspondiente
//$('#listas').on("click", ".remover_campo", function (e) {
//    e.preventDefault();
//    var indiceRemover = $(this).data('indice');
//    campos = campos.filter(function (campo) {
//        return campo.id !== indiceRemover;
//    });
//    $('#inputGroup' + indiceRemover).remove();
//    numCampos--;
//});


//// Actualizar el operador cuando se cambia la selección en el boton
//$('#listas').on("change", ".operator-selector", function () {
//    var indiceCampo = $(this).data('indicePalabra');
//    var nuevoOperador = $(this).val();
//    campos.forEach(function (campo) {
//        if (campo.id === indiceCampo) {
//            campo.operator = nuevoOperador;
//        }
//    });
//});


////Funciona
//function buildQuery(numPalabras, operador) {
//    const searchTerms = Array.from({ length: numPalabras }, (_, i) => `term${i + 1}`);
//    const conditions = searchTerms.map((term, index) => `CONTAINS(InpRelatoHecho, @${term})`);

//    const logicalOperators = operador.split(' ');

//    if (logicalOperators.length === conditions.length - 1) {
//        let query = `SELECT InpFolio, InpRelatoHecho FROM inp_caso WHERE ${conditions[0]}`;
//        for (let i = 0; i < logicalOperators.length; i++) {
//            query += ` ${logicalOperators[i]} ${conditions[i + 1]}`;
//        }
//        return query;
//    } else {
//        throw new Error('Número incorrecto de operadores lógicos en la expresión.');
//    }
//}

////// Ejemplo de uso:
////const numPalabras = 3;
////const operador = 'AND OR';
////const sqlQuery = buildDynamicQuery(numPalabras, searchExpression);
////console.log(sqlQuery);


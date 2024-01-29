let tituloAlerLogins = 'Login - SERCH.';
$(document).ready(function ev() {

    $(".loading-screen").hide();
    $('#ShowPassword').click(function () {
        $('#txtPassWord').attr('type', $(this).is(':checked') ? 'text' : 'password');
    });

    $('#login-form1').on('submit', function (e) {
        // validation code here
        if (!validLogin) {
            e.preventDefault();
        }
    });


    let BrowserValid = 0;
    BrowserValid = $("#BrowserValid").val();
    if (BrowserValid == 0) {
        $(".form-control").each(function () {
            $(this).attr("disabled", "disabled");
        });

        // $(".btn-login").attr("disabled", "disabled");      
        $("#btn_LogInU").hide();
        $("#btn_LohInUError").show();

        Swal.fire(
            tituloAlerLogins,
            'El sistema asegura un completo funcionamiento para el navegador Chrome.',
            'error'
        )
    }
    else
    {
        $("#btn_LogInU").show();
        $("#btn_LohInUError").hide();
    }


    $("input[name=UserName]").keypress(function (event) {
        if (event.keyCode === 13) {
            event.preventDefault();
            $("#btn_LogInU").trigger("click");
        }
    });


    $("input[name=Password]").keypress(function (event) {
        if (event.keyCode === 13) {
            event.preventDefault();
            $("#btn_LogInU").trigger("click");
        }
    });



    $("#btn_LohInUError").on("Click", function (evnt) {
        Swal.fire(
            tituloAlerLogins,
            'El sistema asegura un completo funcionamiento para el navegador Chrome.',
            'error'
        )    
    });


    $("#btn_LogInU").on("click", function (evnt) {
       


        let username = $("input[name=UserName]").val();
        let password = $("input[name=Password]").val();

        if (username == "")
        {
            Swal.fire(
                tituloAlerLogins,
                'Nombre de usuario no puede ser vacio.',
                'error'
            )

           
            return;
        }

        if (password == "") {
            Swal.fire(
                tituloAlerLogins,
                'Contraseña de Usuario AD no puede ser vacio.',
                'error'
            )
            return;
        }

        $(".loading-screen").show();

        let datos = {
            UserName: username,
            Password: password
        };


        $("#spinLoad").show();

        $.ajax({
            cache: false,
            async: true,
            url: '/Home/LogInUsr',
            data: datos,
            type: 'POST',
            beforeSend: function (jqXHR, settings) {
                let UrlService = settings.url.split("/")[1] + "/" + settings.url.split("/")[2];
                jqXHR.servicio = UrlService;
            },
            success: function (response) {
                $("#spinLoad").hide();
                if (response.success) {
                    $("#btn_submits").trigger("click");
                  
                }
                else {
                    $(".loading-screen").hide();
                    if (response.desc == null) {
                        Swal.fire(
                            tituloAlerLogins,
                            'Error al iniciar sessión.',
                            'error'
                        )
                    }
                    else
                    {
                        switch (response.cod) {
                            case 0:
                                Swal.fire(
                                    tituloAlerLogins,
                                    response.desc,
                                    'error'
                                );
                                return;
                                break;

                            case -997:

                                Swal.fire({
                                    title: tituloAlerLogins,
                                    text: response.desc,
                                    icon: 'info',
                                    showCancelButton: true,
                                    confirmButtonColor: '#3085d6',
                                    cancelButtonColor: '#d33',
                                    confirmButtonText: 'Continuar',
                                    cancelButtonText: "Cancelar",
                                }).then((result) => {

                                    if (result.isConfirmed) {
                                        location.href = "../Home/LogOut";
                                    }
                                    else {
                                        location.href = "../Home/LogOut";
                                    }
                                    return;
                                })
                                break;

                            case -998:
                                Swal.fire(
                                    tituloAlerLogins,
                                    response.desc,
                                    'error'
                                );
                                location.href = "../Home/LogOut";
                                return;
                                break;

                            default:
                                Swal.fire(
                                    tituloAlerLogins,
                                    response.desc,
                                    'error'
                                );
                                return;
                                break;
                        }

                    }                   

                }
                
            },
            error: function (er) {

                Swal.fire(
                    tituloAlerLogins,
                    'Error de conexión con el servicio: ' + er.servicio,
                    'error'
                );             
            }
        });

    });

});
    //#endregion Document Ready


//document.addEventListener('DOMContentLoaded', function () {
//  particleground(document.getElementById('particles'), {
//    dotColor: '#5cbdaa',
//    lineColor: '#5cbdaa'
//  });
//  var intro = document.getElementById('intro');
//  intro.style.marginTop = - intro.offsetHeight / 2 + 'px';
//}, false);



function mostrarPassword() {
    var cambio = document.getElementById("password-input");
    if (cambio.type == "password") {
        cambio.type = "text";
        $('.icon-close').hide();
        $('.icon-open').show();
    } else {
        cambio.type = "password";
        $('.icon-close').show();
        $('.icon-open').hide();
    }
} 
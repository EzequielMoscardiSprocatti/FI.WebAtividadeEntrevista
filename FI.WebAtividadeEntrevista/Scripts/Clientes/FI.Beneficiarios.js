
$(document).ready(function () {
    $('#formCadBeneficiario').submit(function (e) {
        e.preventDefault();
        $.ajax({
            url: urlBenef,
            method: "POST",
            data: {
                "NOME": $(this).find("#Nome_Benf").val(),
                "CPF": $(this).find("#CPF_Benf").val(),
                "IDCLIENTE": obj['Id']
            },
            error:
                function (r) {
                    if (r.status == 400)
                        ModalDialog("Ocorreu um erro", r.responseJSON);
                    else if (r.status == 500)
                        ModalDialog("Ocorreu um erro", "Ocorreu um erro interno no servidor.");
                },
            success:
                function (r) {
                    ModalDialog("Sucesso!", r)
                    $("#formCadBeneficiario")[0].reset();
                }
        });
    })

})


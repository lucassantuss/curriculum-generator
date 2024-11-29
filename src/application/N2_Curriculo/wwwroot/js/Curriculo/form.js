function mascaraCPF(cpf) {
    var cpfMascarado = cpf.replace(/\D/g, ''); // remove todos os caracteres que não são números
    cpfMascarado = cpfMascarado.replace(/(\d{3})(\d)/, "$1.$2"); // insere o primeiro ponto após os 3 primeiros dígitos
    cpfMascarado = cpfMascarado.replace(/(\d{3})(\d)/, "$1.$2"); // insere o segundo ponto após os 3 próximos dígitos
    cpfMascarado = cpfMascarado.replace(/(\d{3})(\d{1,2})$/, "$1-$2"); // insere o traço antes dos 2 últimos dígitos

    return cpfMascarado;
}

function apagarExperiencia(id) {
    if (confirm('Confirma a exclusão da experiência profissional selecionada?'))
        location.href = '/Curriculo/DeleteExperiencia?id=' + id;
}

function apagarFormacao(id) {
    if (confirm('Confirma a exclusão da formação acadêmica selecionada?'))
        location.href = '/Curriculo/DeleteFormacao?id=' + id;
}

function apagarIdioma(id) {
    if (confirm('Confirma a exclusão do idioma selecionado?'))
        location.href = '/Curriculo/DeleteIdioma?id=' + id;
}

function modalExperiencia(id) {

    $.ajax({
        url: "/Curriculo/CreateExperiencia?id=" + id,
        dataType: 'html',
        beforeSend: function () {

        },
        success: function (data) {

            $('#modal-body').html(data);
            $('#modal_validacao').modal('show');
            document.getElementById("titulo-modal").innerHTML = 'Experiência Profissional';
        }
    });
}

function modalFormacao(id) {

    $.ajax({
        url: "/Curriculo/CreateFormacao?id=" + id,
        dataType: 'html',
        beforeSend: function () {

        },
        success: function (data) {

            $('#modal-body').html(data);
            $('#modal_validacao').modal('show');
            document.getElementById("titulo-modal").innerHTML = 'Formação Acadêmica';
        }
    });
}

function modalIdioma(id) {

    $.ajax({
        url: "/Curriculo/CreateIdioma?id=" + id,
        dataType: 'html',
        beforeSend: function () {

        },
        success: function (data) {

            $('#modal-body').html(data);
            $('#modal_validacao').modal('show');
            document.getElementById("titulo-modal").innerHTML = 'Idioma';
        }
    });
}

function editarExperiencia(id) {

    $.ajax({
        url: "/Curriculo/EditExperiencia?id=" + id,
        dataType: 'html',
        beforeSend: function () {

        },
        success: function (data) {

            $('#modal-body').html(data);
            $('#modal_validacao').modal('show');
            document.getElementById("titulo-modal").innerHTML = 'Experiência Profissional';
        }
    });
}

function editarFormacao(id) {

    $.ajax({
        url: "/Curriculo/EditFormacao?id=" + id,
        dataType: 'html',
        beforeSend: function () {

        },
        success: function (data) {

            $('#modal-body').html(data);
            $('#modal_validacao').modal('show');
            document.getElementById("titulo-modal").innerHTML = 'Formação Acadêmica';
        }
    });
}

function editarIdioma(id) {

    $.ajax({
        url: "/Curriculo/EditIdioma?id=" + id,
        dataType: 'html',
        beforeSend: function () {

        },
        success: function (data) {

            $('#modal-body').html(data);
            $('#modal_validacao').modal('show');
            document.getElementById("titulo-modal").innerHTML = 'Idioma';
        }
    });
}
function apagarPessoa(id) {
    if (confirm('Confirma a exclusão do registro?'))
        location.href = 'curriculo/Delete?id=' + id;
}
window.VerificarMesa = (codProduto) => {
    $("#codProduto").val(codProduto);
}

function AdicionarConsumo() {

    var codMesa = $('#Mesa option:selected').val();
    var codProduto = $("#codProduto").val();

    $("#Pedir").prop("disabled", true);
    $("#texto").text("Aguarde... Solicitando pedido");
    $("#overlay").fadeIn();　

    $.ajax({
        url: "https://localhost:5003/api/Mesa/AdicionaConsumoMesaPWA?codMesa=" + codMesa + "&codProduto="+codProduto,
        type: 'Post',
        cache: false,
        async: true,
    }).done(function (data) {
        $("#ModalGenric").modal();
        $("#ModalGenric .modal-body").text(data['message']);
        $("#texto").text("");
        $("#Pedir").prop("disabled", false);
        $("#overlay").fadeOut();
    }).fail(function (data) {
        $("#ModalGenric").modal();
        $("#ModalGenric .modal-body").text(data['message']);
        $("#texto").text("");
    });
}

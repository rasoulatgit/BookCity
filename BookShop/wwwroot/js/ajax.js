$(function () {

    $("button[data-toggle='ajax-modal']").click(function () {
        $.ajax({
            url: $(this).data('url'),
            type: 'get',
        }).done(function (data) {
            $('#placeholder').html(data);
            $('#placeholder').find('.modal').modal('show');
        });
    });

});
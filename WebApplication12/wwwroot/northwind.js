$(() => {
    $(".highlight").on('click', function() {
        $(this).closest('tr').addClass('danger');
    })
})
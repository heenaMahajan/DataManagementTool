var customClientList = {
    init: function () {
        customClientList.getClientDetails();
    },
    initTable: function () {
        $('#clientTable').DataTable({
            pageLength: 10,
            responsive: true,
            dom: '<"html5buttons"B>lTfgtip',
            buttons: [
                {
                    //extend: 'print',
                    customize: function (win) {
                        $(win.document.body).addClass('white-bg');
                        $(win.document.body).css('font-size', '10px');
                        $(win.document.body).find('table')
                            .addClass('compact')
                            .css('font-size', 'inherit');
                    }
                }
            ]

        });
        $('.html5buttons').hide();
        $(".dataTables_filter").find('label').css('float', 'right');
    },
    getClientDetails: function () {
        $.ajax({
            type: "GET",
            url: '/Client/GetClientDetails',
            contentType: "application/json; charset=utf-8",
            dataType: "html",
            async: true,
            success: function (data) {
                $("#clientList").html(data);
                customClientList.initTable();
            },
            failure: function (response) {
                //$(".loading").hide();

            }
        });

    },
    onSuccess: function (data) {
        if (data.data.success == true) {
            customClientList.snackerBar(data.data.message, data.data.color);
            customClientList.getClientDetails();
            setTimeout(function () { window.location.href = '/Client/Index'; }, 2000);
        }
        else {
            customClientList.snackerBar(data.data.message, data.data.color);
        }

    },
    onFailed: function (data) {
        customClientList.snackerBar(data.data.message.message, data.data.color);
    },
    snackerBar: function (message, color) {
        var x = document.getElementById("snackbar")
        x.className = "show";
        $('#snackbar').html(message).css('background-color', color);
        setTimeout(function () { x.className = x.className.replace("show", ""); }, 2000);
    },
    deleteClient: function (item) {
        var val = item.dataset.id;
        swal({
            title: "Are you sure?",
            text: "You want to delete this client",
            type: "warning",
            showCancelButton: true,
            confirmButtonColor: "#DD6B55",
            confirmButtonText: "Yes, delete it!",
            closeOnConfirm: false
        }, function () {
            $.ajax({
                url: '/Client/DeleteClient',
                type: 'POST',
                data: { id: val },
                async: true,
                success: function (data) {
                    swal({
                        title: "Deleted!",
                        text: "Client has been deleted.",
                        type: "success"
                    }, function () {
                        customClientList.getClientDetails();
                        window.location.reload(true);
                    });
                },
                error: function () {
                    swal("response", "", "error");
                },
            });

        })
    },
    onSuccessEdit: function (data) {
        if (data.data.success == true) {
            customClientList.snackerBar(data.data.message, data.data.color);
            customClientList.getClientDetails();
            setTimeout(function () { window.location.href = '/Client/Index'; }, 2000);
        }
        else {
            customClientList.snackerBar(data.data.message, data.data.color);
        }
    },

    onFailedEdit: function (data) {
        customClientList.snackerBar(data.data.message, data.data.color);
    }

};
$(document).ready(function ()
{
    customClientList.init();
});

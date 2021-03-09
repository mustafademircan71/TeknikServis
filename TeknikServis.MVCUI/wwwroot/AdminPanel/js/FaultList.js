$(function () {
   
    $("#btnSave").click(function () {
        var vm={
            FaultName: $("#txtFaultName").val(),
            IsActive: $("#gridCheck").is(":checked")
        };
        $.ajax({
            url: "/fault-new",
            method: "post",
            datatype: "json",
            data: { vm: vm },
            success: function (resp) {
                if (resp.result) {
                    Swal.fire({
                        icon: 'success',
                        title: 'İşlem Başarılı',
                        text: resp.message
                    }).then((result) => {
                        if (result.isConfirmed) {
                            window.location.reload();
                        }
                    });
                }
                else {
                    Swal.fire({
                        icon: 'error',
                        title: 'Hata!!!',
                        text: response.message
                    })
                }
            }
        });
    });

    $(".btnEdit").click(function () {
        var faultId = $(this).attr("faultid");
        $.ajax({
            url: "/fault-details",
            method: "post",
            datatype: "json",
            data: { id: faultId },
            success: function (resp) {
                $("#txtFaultNameUpdate").val(resp.faultInfo.faultName);
                $("#gridCheckUpdate").prop('checked', resp.faultInfo.isActive);
                $("#hfFaultIdUpdate").val(resp.faultInfo.id);
            }
        });
        $("#divUpdateFaultForm").modal("show");
    });

    $("#btnSaveUpdate").click(function () {
        var vm = {
            Id: $("#hfFaultIdUpdate").val(),
            IsActive: $("#gridCheckUpdate").is(":checked"),
            FaultName: $("#txtFaultNameUpdate").val()
        }
        $.ajax({
            url: "/fault-update",
            method: "post",
            datatype: "json",
            data: { vm: vm },
            success: function (resp) {
                if (resp.result) {
                    Swal.fire({
                        icon: 'success',
                        title: 'İşlem Başarılı',
                        text: resp.message
                    }).then((result) => {
                        if (result.isConfirmed) {
                            window.location.reload();
                        }
                    });
                }
              
                
            }
        });
    });

    $('#tblFaultList').DataTable({
        "paging": true,
        "ordering": false,
        "searching": true,
        "language": {
            "sDecimal": ",",
            "sEmptyTable": "Tabloda herhangi bir veri mevcut değil",
            "sInfo": "_TOTAL_ kayıttan _START_ - _END_ arasındaki kayıtlar gösteriliyor",
            "sInfoEmpty": "Kayıt yok",
            "sInfoFiltered": "(_MAX_ kayıt içerisinden bulunan)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "Sayfada _MENU_ kayıt göster",
            "sLoadingRecords": "Yükleniyor...",
            "sProcessing": "İşleniyor...",
            "sSearch": "Ara:",
            "sZeroRecords": "Eşleşen kayıt bulunamadı",
            "oPaginate": {
                "sFirst": "İlk",
                "sLast": "Son",
                "sNext": "Sonraki",
                "sPrevious": "Önceki"
            },
            "oAria": {
                "sSortAscending": ": artan sütun sıralamasını aktifleştir",
                "sSortDescending": ": azalan sütun sıralamasını aktifleştir"
            },
            "select": {
                "rows": {
                    "_": "%d kayıt seçildi",
                    "0": "",
                    "1": "1 kayıt seçildi"
                }
            }
        }
    });
});
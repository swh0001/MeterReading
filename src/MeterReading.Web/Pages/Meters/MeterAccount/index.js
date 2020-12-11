$(function () {

    var l = abp.localization.getResource('MeterReading');

    var service = meterReading.meters.meterAccount;
    var createModal = new abp.ModalManager(abp.appPath + 'Meters/MeterAccount/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Meters/MeterAccount/EditModal');

    var dataTable = $('#MeterAccountTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('MeterReading.MeterAccount.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('MeterReading.MeterAccount.Delete'),
                                confirmMessage: function (data) {
                                    return l('MeterAccountDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            { data: "meterName" },
            { data: "meterLevel" },
            { data: "fatherMeterID" },
            { data: "isVirtual" },
            { data: "spareFor" },
            { data: "reader" },
            { data: "userName" },
            { data: "routeNO1" },
            { data: "routeNO2" },
            { data: "routeNO3" },
            { data: "plantID" },
            { data: "mediaTypeID" },
            { data: "userTypeID" },
            { data: "reportCycleID" },
            { data: "meterID" },
            { data: "magnification" },
            { data: "peak" },
            { data: "valley" },
            { data: "flat" },
            { data: "value" },
            { data: "perValue" },
            { data: "diffValue" },
            { data: "adjustment" },
            { data: "reportValue" },
            { data: "perReportValue" },
            { data: "diffReportValue" },
            { data: "temperature" },
            { data: "pressure" },
            { data: "currentCycle" },
            { data: "balanceRatio" },
            { data: "isBalance" },
            { data: "isEnable" },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewMeterAccountButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});

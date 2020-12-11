$(function () {

    var l = abp.localization.getResource('MeterReading');

    var service = meterReading.meters.meterAccountReading;
    //var createModal = new abp.ModalManager(abp.appPath + 'Meters/MeterAccountReading/CreateModal');
    var editModalReading = new abp.ModalManager(abp.appPath + 'Meters/MeterAccountReading/EditModalReading');

    var dataTable = $('#MeterAccountReadingTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('MeterReading.MeterAccountReading.Update'),
                                action: function (data) {
                                    editModalReading.open({ id: data.record.id });
                                }
                            },
                            //{
                            //    text: l('Delete'),
                            //    visible: abp.auth.isGranted('MeterReading.MeterAccount.Delete'),
                            //    confirmMessage: function (data) {
                            //        return l('MeterAccountDeletionConfirmationMessage', data.record.id);
                            //    },
                            //    action: function (data) {
                            //        service.delete(data.record.id)
                            //            .then(function () {
                            //                abp.notify.info(l('SuccessfullyDeleted'));
                            //                dataTable.ajax.reload();
                            //            });
                            //    }
                            //}
                        ]
                }
            },
            { data: "meterName" },
            // { data: "meterLevel" },
            // { data: "fatherMeterID" },
            //  { data: "isVirtual" },
            //  { data: "spareFor" },
            { data: "reader" },
            // { data: "userName" },
            { data: "routeNO1" },
            { data: "routeNO2" },
            { data: "routeNO3" },
            // { data: "plantID" },
            // { data: "mediaTypeID" },
            //  { data: "userTypeID" },
            //  { data: "reportCycleID" },
            { data: "meterID" },
            //  { data: "magnification" },
            //  { data: "peak" },
            // { data: "valley" },
            //  { data: "flat" },
            { data: "value" },
            // { data: "perValue" },
            // { data: "diffValue" },
            //{ data: "adjustment" },
            //{ data: "reportValue" },
            //{ data: "perReportValue" },
            //{ data: "diffReportValue" },
            //{ data: "temperature" },
            //{ data: "pressure" },
            //{ data: "currentCycle" },
        ]
    }));

    //createModal.onResult(function () {
    //    dataTable.ajax.reload();
    //});

    editModalReading.onResult(function () {
        dataTable.ajax.reload();
    });

    //$('#NewMeterAccountButton').click(function (e) {
    //    e.preventDefault();
    //    createModal.open();
    //});
});

var venuesKendoUIManagement = (function () {

    var DOM = {
        VenuesGrid: $("#venuesGrid"),
    }

    var globalData = {
        baseURL: "../"
    }

    function bindEvents() { }

    function bindControls() { }

    function initVenuesGrid() {
        DOM.VenuesGrid.kendoGrid({
            dataSource: {
                transport: {
                    read: function (options) {
                        $.ajax({
                            url: globalData.baseURL + "Venues/GetVenueDTOs",
                            type: "GET",
                            contentType: "application/json; charset=utf-8",
                            dataType: "JSON",
                            success: function (result) {
                                options.success(result);
                            },
                            error: function (result) {
                                options.error(result);
                            }
                        });
                    }
                },
                schema: {
                    model: {
                        id: "Id",
                        fields: {
                            Name: "Name",
                            Image: "Image",
                            Street: "Street",
                            Location: "Location",
                            GeoLocation: "GeoLocation",
                            OpenTime: "OpenTime",
                            CloseTime: "CloseTime",
                            LowerPrice: "LowerPrice",
                            UpperPrice: "UpperPrice",
                            Status: "Status"
                        }
                    }
                }
            },
            pageable: {
                pageSize: 10,
                refresh: true,
                serverPaging: true,
                serverFiltering: true,
                serverSorting: true,
            },
            sortable: true,
            navigatable: true,
            resizable: true,
            reorderable: true,
            filterable: true,
            columns: [
                {
                    selectable: true,
                    attributes: {
                        "class": "kendo-checkbox"
                    },
                    headerAttributes: {
                        "class": "kendo-checkbox"
                    },
                },
                {
                    field: "Id",
                    title: "Id",
                    template: "<div>#:Id#</div>",
                },
                {
                    field: "Name",
                    title: "Name",
                    template: "<div>#:Name#</div>",
                },
                {
                    field: "Image",
                    title: "Image",
                    template: "<div>#:Image#</div>",
                },
                {
                    field: "Street",
                    title: "Street",
                    template: "<div>#:Street#</div>",
                },
                {
                    field: "Location",
                    title: "Location",
                    template: "<div>#:Location#</div>",
                },
                {
                    field: "GeoLocation",
                    title: "GeoLocation",
                    template: "<div>#:GeoLocation#</div>",
                },
                {
                    field: "OpenTime",
                    title: "OpenTime",
                    template: "<div>#:OpenTime#</div>",
                },
                {
                    field: "CloseTime",
                    title: "CloseTime",
                    template: "<div>#:CloseTime#</div>",
                },
                {
                    field: "LowerPrice",
                    title: "LowerPrice",
                    template: "<div>#:LowerPrice#</div>",
                },
                {
                    field: "UpperPrice",
                    title: "UpperPrice",
                    template: "<div>#:UpperPrice#</div>",
                },
                {
                    field: "Status",
                    title: "Status",
                    template: "<div>#:Status#</div>",
                },
            ],
        });
    }

    return {
        init: function () {
            bindEvents();
            bindControls();
            initVenuesGrid();
        }
    }

})();

$(document).ready(function () {
    venuesKendoUIManagement.init();
});
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
                batch: true,
                autoSync: true,
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
                pageSize: 5,
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
            scrollable: true,
            columns: [
                {
                    selectable: true,
                    width: 50,
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
                    width: 50,
                },
                {
                    field: "Name",
                    title: "Name",
                    template: "<div>#:Name#</div>",
                    width: 100,
                },
                {
                    field: "Image",
                    title: "Image",
                    template:
                        "<div style=\"height: 100px;\">" +
                        "<img style=\"width: 100%; height: 100%;\" src=\"#:Image#\" />" +
                        "</div>",
                    width: 100,
                },
                {
                    field: "Street",
                    title: "Street",
                    template: "<div>#:Street#</div>",
                    width: 100,
                },
                {
                    field: "Location",
                    title: "Location",
                    template: "<div>#:Location#</div>",
                    width: 100,
                },
                {
                    field: "GeoLocation",
                    title: "GeoLocation",
                    template: "<div>#:GeoLocation#</div>",
                    width: 100,
                },
                {
                    field: "OpenTime",
                    title: "OpenTime",
                    template: "<div>#:OpenTime#</div>",
                    width: 100,
                },
                {
                    field: "CloseTime",
                    title: "CloseTime",
                    template: "<div>#:CloseTime#</div>",
                    width: 100,
                },
                {
                    field: "LowerPrice",
                    title: "LowerPrice",
                    template: "<div>#:LowerPrice#</div>",
                    width: 100,
                },
                {
                    field: "UpperPrice",
                    title: "UpperPrice",
                    template: "<div>#:UpperPrice#</div>",
                    width: 100,
                },
                {
                    field: "Status",
                    title: "Status",
                    template: "<div>#:Status#</div>",
                    width: 100,
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
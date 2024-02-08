var categoriesKendoUIManagement = (function () {

    var DOM = {
        CategoriesGrid: $("#categoriesGrid"),
        Popup: document.getElementById("popup")
    }

    var globalData = {
        baseURL: "../"
    }

    function bindEvents() { }

    function bindControls() { }

    function initCategoriesGrid() {
        DOM.CategoriesGrid.kendoGrid({
            dataSource: {
                transport: {
                    read: function (options) {
                        $.ajax({
                            url: globalData.baseURL + "Categories/GetCategoryAdminDTOs",
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
                            Id: { type: "number", editable: false, nullable: false },
                            Name: { type: "string", editable: false },
                            SubCategoryNumber: { type: "number", editable: false },
                            VenueNumber: { type: "number", editable: false }
                        }
                    }
                }
            },
            height: AutoFitHeight,
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
            scrollable: true,
            filterable: true,
            detailInit: detailInit,
            dataBound: onDataBound,
            toolbar: [
                {
                    name: "create",
                    text: "Thêm Phân Loại",
                },
                {
                    name: "cancel",
                    text: "Đổi Trạng Thái",
                }
            ],
            columns: [
                {
                    field: "Name",
                    headerTemplate: "<div class=\"kendo-grid-header\"><strong>Tên</strong></div>",
                    template: "<div class=\"kendo-grid-cell\">#:Name#</div>",
                    width: 250,
                    sortable: false,
                    filterable: false
                },
                {
                    field: "SubCategoryNumber",
                    headerTemplate: "<div class=\"kendo-grid-header\"><strong>Số lượng thể loại phụ</strong></div>",
                    template: "<div class=\"kendo-grid-cell\">#:SubCategoryNumber#</div>",
                    width: 250,
                    sortable: false,
                    filterable: false
                },
                {
                    field: "Name",
                    headerTemplate: "<div class=\"kendo-grid-header\"><strong>Số lượng địa điểm</strong></div>",
                    template: "<div class=\"kendo-grid-cell\">#:VenueNumber#</div>",
                    width: 250,
                    sortable: false,
                    filterable: false
                },
                {
                    template:
                        "<div class=\"kendo-grid-cell\">" +
                        "<button type=\"button\" class=\"btn btn-info kendo-grid-btn\">Cập Nhật</button>" +
                        "</div>",
                    width: 100
                },
            ]
        });
    }

    function AutoFitHeight() {
        return document.documentElement.clientHeight -
            (
                document.querySelector(".main-header").clientHeight +
                document.querySelector(".main-footer").clientHeight
            );
    }

    function detailInit(e) {
        $("<div/>").appendTo(e.detailCell).kendoGrid({
            dataSource: {
                transport: {
                    read: function (options) {
                        $.ajax({
                            url: globalData.baseURL + "SubCategories/GetSubCategoryAdminDTOs",
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
                            Id: { type: "number", editable: false, nullable: false },
                            Name: { type: "string", editable: false },
                            CategoryId: { type: "number", editable: false },
                            VenueNumber: { type: "number", editable: false }
                        }
                    }
                },
                filter: {
                    field: "CategoryId",
                    operator: "eq",
                    value: e.data.Id
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
            scrollable: true,
            filterable: true,
            columns: [
                {
                    selectable: true,
                    width: 50,
                    headerAttributes: {
                        "class": "kendo-checkbox"
                    },
                    attributes: {
                        "class": "kendo-checkbox"
                    }
                },
                {
                    field: "Name",
                    headerTemplate: "<div class=\"kendo-grid-header\"><strong>Tên</strong></div>",
                    template: "<div class=\"kendo-grid-cell\">#:Name#</div>",
                    width: 250,
                    sortable: false,
                    filterable: false
                },
                {
                    field: "VenueNumber",
                    headerTemplate: "<div class=\"kendo-grid-header\"><strong>Số lượng địa điểm</strong></div>",
                    template: "<div class=\"kendo-grid-cell\">#:VenueNumber#</div>",
                    width: 250,
                    sortable: false,
                    filterable: false
                },
                {
                    template:
                        "<div class=\"kendo-grid-cell\">" +
                        "<button type=\"button\" class=\"btn btn-info kendo-grid-btn\">Cập Nhật</button>" +
                        "</div>",
                    width: 100
                },
            ]
        });
    }

    function onDataBound(e) {
        this.expandRow(this.tbody.find("tr.k-master-row").first());
    }

    return {
        init: function () {
            initCategoriesGrid();
            bindEvents();
            bindControls();
        }
    }

})();

$(function () {
    categoriesKendoUIManagement.init();
});

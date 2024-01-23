var categoriesKendoUIManagement = (function () {

    var DOM = {
        CategoriesGrid: $("#categoriesGrid"),
        Popup: document.getElementById("popup"),
    }

    var globalData = {
        baseURL: "../"
    }

    function bindEvents() {
        InsertButton();
        DeleteButton();
    }

    function bindControls() { }

    function initCategoriesGrid() {
        DOM.CategoriesGrid.kendoGrid({
            dataSource: {
                transport: {
                    read: function (options) {
                        $.ajax({
                            url: globalData.baseURL + "",
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
                           
                        }
                    }
                }
            },
            height: 680,
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
                    template:
                        "<div style=\"display: flex; flex-direction: row; align-items: center;\">" +
                        "<div class=\"kendo-cell-photo\" style=\"background-image: url(#:Image#);\"></div>" +
                        "<div class=\"kendo-cell-name\">#:Name#</div>" +
                        "</div>",
                    width: 250,
                    sortable: false,
                    filterable: {
                        extra: false,
                        showOperators: false,
                        messages: {
                            info: "",
                            filter: "Lọc",
                            clear: "Xoá"
                        },
                        operators: {
                            string: {
                                contains: "Bao Gồm",
                                doesnotcontain: "Không Bao Gồm"
                            }
                        }
                    }
                },
               
                {
                    field: "Status",
                    headerTemplate: "<div class=\"kendo-grid-header\"><strong>Trạng Thái</strong></div>",
                    template: "<div class=\"kendo-grid-cell\"><div class=\"badgeTemplate\"></div></div>",
                    width: 150
                },
                {
                    template:
                        "<div class=\"kendo-grid-cell\">" +
                        "<button type=\"button\" class=\"btn btn-info kendo-grid-btn\">Cập Nhật</button>" +
                        "</div>",
                    width: 100
                },
            ],
        });
    }

    function onDataBound(e) {
        var grid = this;

        grid.table.find("tr").each(function () {
            var dataItem = grid.dataItem(this);
            var themeColor = dataItem.Status ? "success" : "error";
            var text = dataItem.Status ? "Hoạt Động" : "Ngưng Hoạt Động";

            $(this).find(".badgeTemplate").kendoBadge({
                themeColor: themeColor,
                text: text,
            });
        });
    }

 /*  function InsertButton() {
        $(".k-grid-add:first").click(function () {
            $.ajax({
                url: globalData.baseURL + "Venues/InsertVenuePopup",
                type: "GET",
                success: function (result) {
                    DOM.Popup.innerHTML = result;
                    RemovePopup();
                },
                error: function (result) {
                    console.log(result);
                }
            });
        });
    }

    function DeleteButton() {
        $(".k-grid-cancel-changes:first").click(function () {
            var ids = DOM.VenuesGrid.data("kendoGrid").selectedKeyNames();
            console.log(ids);
            DOM.VenuesGrid.data("kendoGrid").dataSource.read();
            //$.ajax({
            //    url: globalData.baseURL + "Venues/DeleteVenue",
            //    type: "DELETE",
            //    success: function (result) {
            //        DOM.Popup.innerHTML = result;
            //        RemovePopup();
            //    },
            //    error: function (result) {
            //        console.log(result);
            //    }
            //});
        });
    } */

    function RemovePopup() {
        $("#removePopup").click(function () {
            DOM.Popup.innerHTML = "";
        })
    }

    return {
        init: function () {
            initCategoriesGrid();
            bindEvents();
            bindControls();
        }
    }

})();

$(document).ready(function () {
     categoriesKendoUIManagement.init();
});

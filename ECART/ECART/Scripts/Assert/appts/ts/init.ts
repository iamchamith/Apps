module ECart.Init {

    var path = ECart.Config.BaseUrl;
    function getCategories(): JQueryXHR {
        try {
            return $.ajax({
                url: path +'/categories',
                method: 'get',
                contentType: "application/json; charset=utf-8"
            });
        } catch (ex) { throw ex; }
    }
    var init = {
        init: () => {
            init.loadLeftMenu();
            init.loadTopMenu();
        },
        loadLeftMenu: () => {
            getCategories().done((data) => {
                var template = kendo.template($("#template-categories").html());
                var result = template(data);
                $("#leftMenuPlaceHolder").html(result);
            }).fail((e) => {

            });
        },
        loadTopMenu: () => {
            var s: any = sessionStorage;
            var obj: any = s.user;
            var tx;
            if (typeof (obj) == 'undefined') {
                tx = '#template-logoutMenu';
            } else {
                tx = '#template-loginMenu';
            }
            $("#navbar").html($(tx).html());
        }
    }

    $(document).ready(init.init);
}
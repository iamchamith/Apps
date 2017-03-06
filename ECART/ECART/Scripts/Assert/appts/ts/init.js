var ECart;
(function (ECart) {
    var Init;
    (function (Init) {
        var path = ECart.Config.BaseUrl;
        function getCategories() {
            try {
                return $.ajax({
                    url: path + '/categories',
                    method: 'get',
                    contentType: "application/json; charset=utf-8"
                });
            }
            catch (ex) {
                throw ex;
            }
        }
        var init = {
            init: function () {
                init.loadLeftMenu();
                init.loadTopMenu();
            },
            loadLeftMenu: function () {
                getCategories().done(function (data) {
                    var template = kendo.template($("#template-categories").html());
                    var result = template(data);
                    $("#leftMenuPlaceHolder").html(result);
                }).fail(function (e) {
                });
            },
            loadTopMenu: function () {
                var s = sessionStorage;
                var obj = s.user;
                var tx;
                if (typeof (obj) == 'undefined') {
                    tx = '#template-logoutMenu';
                }
                else {
                    tx = '#template-loginMenu';
                }
                $("#navbar").html($(tx).html());
            }
        };
        $(document).ready(init.init);
    })(Init = ECart.Init || (ECart.Init = {}));
})(ECart || (ECart = {}));
//# sourceMappingURL=init.js.map
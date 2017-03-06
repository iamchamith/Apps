var ECart;
(function (ECart) {
    var User;
    (function (User) {
        var user = (function () {
            var baseUrl = '';
            var apiCalles = {
                login: function (e) {
                    try {
                        return $.ajax({
                            url: '',
                            data: JSON.stringify(e),
                            method: 'post',
                        });
                    }
                    catch (ex) {
                        throw ex;
                    }
                },
                register: function (e) {
                    try {
                        return $.ajax({});
                    }
                    catch (ex) {
                        throw ex;
                    }
                },
                forgetPassword: function (e) {
                    try {
                        return $.ajax({});
                    }
                    catch (ex) {
                        throw ex;
                    }
                },
                changeSettings: function (e) {
                    try {
                        return $.ajax({});
                    }
                    catch (ex) {
                        throw ex;
                    }
                },
                changePassword: function (e) {
                    try {
                        return $.ajax({});
                    }
                    catch (ex) {
                        throw ex;
                    }
                }
            };
            function login() {
                try {
                    var e;
                    apiCalles.login(e).done(function (r) {
                    }).fail(function (r) {
                        ECart.ErrorHandler.handleErrors(e);
                    });
                }
                catch (ex) {
                    throw ex;
                }
            }
            function register() {
                try {
                    var e;
                    apiCalles.login(e).done(function (r) {
                    }).fail(function (r) {
                        ECart.ErrorHandler.handleErrors(e);
                    });
                }
                catch (ex) {
                    throw ex;
                }
            }
            function forgetPassword() {
                try {
                    var e;
                    apiCalles.login(e).done(function (r) {
                    }).fail(function (r) {
                        ECart.ErrorHandler.handleErrors(e);
                    });
                }
                catch (ex) {
                    throw ex;
                }
            }
            function changePassword() {
                try {
                    var e;
                    apiCalles.changePassword(e).done(function (r) {
                    }).fail(function (r) {
                        ECart.ErrorHandler.handleErrors(e);
                    });
                }
                catch (ex) {
                    throw ex;
                }
            }
            function changeSettings() {
                try {
                    var e;
                    apiCalles.changeSettings(e).done(function (r) {
                    }).fail(function (r) {
                        ECart.ErrorHandler.handleErrors(e);
                    });
                }
                catch (ex) {
                    throw ex;
                }
            }
            function initControlles() {
                try {
                    var e;
                    apiCalles.login(e).done(function (r) {
                    }).fail(function (r) {
                        ECart.ErrorHandler.handleErrors(e);
                    });
                }
                catch (ex) {
                    throw ex;
                }
            }
            return {
                init: function () {
                    try {
                        initControlles();
                    }
                    catch (ex) {
                        throw ex;
                    }
                }
            };
        })();
    })(User = ECart.User || (ECart.User = {}));
})(ECart || (ECart = {}));
//# sourceMappingURL=user.js.map
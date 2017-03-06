module ECart.User {
    var user = (() => {
        var baseUrl = '';
        var apiCalles = {
            login: (e: ViewModel.UserMvvm): JQueryXHR => {
                try {
                    return $.ajax({
                        url: '',
                        data: JSON.stringify(e),
                        method: 'post',
                        
                    });
                } catch (ex) {
                    throw ex;
                }
            },
            register: (e: ViewModel.UserMvvm): JQueryXHR => {
                try {
                    return $.ajax({});
                } catch (ex) {
                    throw ex;
                }
            },
            forgetPassword: (e: ViewModel.UserMvvm): JQueryXHR => {
                try {
                    return $.ajax({});
                } catch (ex) {
                    throw ex;
                }
            },
            changeSettings: (e: ViewModel.UserMvvm): JQueryXHR => {
                try {
                    return $.ajax({});
                } catch (ex) {
                    throw ex;
                }
            },
            changePassword: (e: ViewModel.UserMvvm): JQueryXHR => {
                try {
                    return $.ajax({});
                } catch (ex) {
                    throw ex;
                } }
        }
        function login() {
            try {
                var e: any;
                apiCalles.login(e).done((r) => {

                }).fail((r) => {
                    ECart.ErrorHandler.handleErrors(e);
                });
            } catch (ex) {
                throw ex;
            }
        }
        function register() {
            try {
                var e: any;
                apiCalles.login(e).done((r) => {

                }).fail((r) => {
                    ECart.ErrorHandler.handleErrors(e);
                });
            } catch (ex) {
                throw ex;
            }
        }
        function forgetPassword() {
            try {
                var e: any;
                apiCalles.login(e).done((r) => {

                }).fail((r) => {
                    ECart.ErrorHandler.handleErrors(e);
                });
            } catch (ex) {
                throw ex;
            }
        }
        function changePassword() {
            try {
                var e: any;
                apiCalles.changePassword(e).done((r) => {

                }).fail((r) => {
                    ECart.ErrorHandler.handleErrors(e);
                });
            } catch (ex) {
                throw ex;
            }
        } function changeSettings() {
            try {
                var e: any;
                apiCalles.changeSettings(e).done((r) => {

                }).fail((r) => {
                    ECart.ErrorHandler.handleErrors(e);
                });
            } catch (ex) {
                throw ex;
            }
        }
        function initControlles() {
            try {
                var e: any;
                apiCalles.login(e).done((r) => {

                }).fail((r) => {
                    ECart.ErrorHandler.handleErrors(e);
                });
            } catch (ex) {
                throw ex;
            }

        }
        return {
            init: () => {
                try {
                    initControlles();
                } catch (ex) {
                    throw ex;
                }
            }
        }
    })();
}

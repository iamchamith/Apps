var ECart;
(function (ECart) {
    var Item;
    (function (Item) {
        var item = (function () {
            var basePath = "";
            var apiCalles = {
                insert: function (e) {
                    try {
                        return $.ajax({
                            url: basePath + '',
                            contentType: "application/json; charset=utf-8",
                            method: 'post',
                            data: JSON.stringify(e)
                        });
                    }
                    catch (ex) {
                        throw ex;
                    }
                },
                update: function (e) {
                    try {
                        return $.ajax({
                            url: basePath + '',
                            contentType: "application/json; charset=utf-8",
                            method: 'post',
                            data: JSON.stringify(e)
                        });
                    }
                    catch (ex) {
                        throw ex;
                    }
                },
                remove: function (e) {
                    try {
                        return $.ajax({
                            url: basePath + '',
                            contentType: "application/json; charset=utf-8",
                            method: 'post',
                            data: JSON.stringify(e)
                        });
                    }
                    catch (ex) {
                        throw ex;
                    }
                },
                select: function (e) {
                    try {
                        return $.ajax({
                            url: basePath + '',
                            contentType: "application/json; charset=utf-8",
                            method: 'post',
                            data: e
                        });
                    }
                    catch (ex) {
                        throw ex;
                    }
                },
                selectById: function (e) {
                    try {
                        return $.ajax({
                            url: basePath + '',
                            contentType: "application/json; charset=utf-8",
                            method: 'post',
                            data: e
                        });
                    }
                    catch (ex) {
                        throw ex;
                    }
                }
            };
            function insert() {
                try {
                    apiCalles.insert().done(function (r) {
                    }).fail(function (r) {
                    });
                }
                catch (ex) {
                    throw ex;
                }
            }
            function update() {
                try {
                    apiCalles.update().done(function (r) {
                    }).fail(function (r) {
                    });
                }
                catch (ex) {
                    throw ex;
                }
            }
            function remove() {
                try {
                    apiCalles.remove().done(function (r) {
                    }).fail(function (r) {
                    });
                }
                catch (ex) {
                    throw ex;
                }
            }
            function select() {
                try {
                    apiCalles.select().done(function (r) {
                    }).fail(function (r) {
                    });
                }
                catch (ex) {
                    throw ex;
                }
            }
            function selectById() {
                try {
                    apiCalles.selectById().done(function (r) {
                    }).fail(function (r) {
                    });
                }
                catch (ex) {
                    throw ex;
                }
            }
            function initControlles() {
            }
            return {
                init: function () { }
            };
        })();
    })(Item = ECart.Item || (ECart.Item = {}));
})(ECart || (ECart = {}));
//# sourceMappingURL=item.js.map
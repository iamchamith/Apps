module ECart.Item {

    var item = (() => {
        var basePath = "";
        var apiCalles = {
            insert: (e?: ECart.ViewModel.ItemMvvm): JQueryXHR => {
                try {
                    return $.ajax({
                        url: basePath + '',
                        contentType: "application/json; charset=utf-8",
                        method: 'post',
                        data: JSON.stringify(e)
                    });
                } catch (ex) {
                    throw ex;
                }
            },
            update: (e?: ECart.ViewModel.ItemMvvm): JQueryXHR => {
                try {
                    return $.ajax({
                        url: basePath + '',
                        contentType: "application/json; charset=utf-8",
                        method: 'post',
                        data: JSON.stringify(e)
                    });
                } catch (ex) {
                    throw ex;
                }
            },
            remove: (e?: number): JQueryXHR => {
                try {
                    return $.ajax({
                        url: basePath + '',
                        contentType: "application/json; charset=utf-8",
                        method: 'post',
                        data: JSON.stringify(e)
                    });
                } catch (ex) {
                    throw ex;
                }
            },
            select: (e?: any): JQueryXHR => {
                try {
                    return $.ajax({
                        url: basePath + '',
                        contentType: "application/json; charset=utf-8",
                        method: 'post',
                        data: e
                    });
                } catch (ex) {
                    throw ex;
                }
            },
            selectById: (e?: number): JQueryXHR => {
                try {
                    return $.ajax({
                        url: basePath + '',
                        contentType: "application/json; charset=utf-8",
                        method: 'post',
                        data: e
                    });
                } catch (ex) {
                    throw ex;
                }
            }
        }
        function insert() {
            try {
                apiCalles.insert().done((r) => {

                }).fail((r) => {

                });
            } catch (ex) { throw ex; }
        }
        function update() {
            try {
                apiCalles.update().done((r) => {

                }).fail((r) => {

                });
            } catch (ex) { throw ex; }
        }
        function remove() {
            try {
                apiCalles.remove().done((r) => {

                }).fail((r) => {

                });
            } catch (ex) { throw ex; }
        }
        function select() {
            try {
                apiCalles.select().done((r) => {

                }).fail((r) => {

                });
            } catch (ex) { throw ex; }
        }
        function selectById() {
            try {
                apiCalles.selectById().done((r) => {

                }).fail((r) => {

                });
            } catch (ex) { throw ex; }
        }

        function initControlles() {

        }

        return {
            init: () => { }
        }
    })();
}

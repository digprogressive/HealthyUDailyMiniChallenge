Resource = (function () {


    return function (resourceUrl, options) {
        var resource = resourceUrl;
        options = options || {};
        options.accept = options.accept || "application/json";
        options.contentType = options.contentType || "application/json";

        var requestHeaders = {
            Accept: options.accept,
            "Content-Type": options.contentType
        };

        this.get = function (id) {
            var getUrl = resource;
            if (id) {
                getUrl += id;
            }
            return $.ajax(getUrl, {
               type: "GET",
               headers: requestHeaders
            });

        };

        this.post = function (entity) {
            return $.ajax(resource, {
                type: "POST",
                data: JSON.stringify(entity),
                headers: requestHeaders
            });
        };
        this.put = function (id, entity) {
            return $.ajax(resource + id, {
                type: "PUT",
                data: JSON.stringify(entity),
                headers: requestHeaders
            });
        };
        this.del = function (id) {
            return $.ajax(resource + id, {
                type: "DELETE"
            });
        };
    };
})();
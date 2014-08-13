function RequestUrlCN() {
}

RequestUrlCN.prototype.GetUrl = function (url, succ_cb, err_cb) {
  cordova.exec(succ_cb, err_cb, "RequestUrlCN", "show", [url]);
};

RequestUrlCN.install = function () {
  if (!window.plugins) {
    window.plugins = {};
  }

  window.plugins.requesturlcn = new RequestUrlCN();
  return window.plugins.requesturlcn;
};

cordova.addConstructor(RequestUrlCN.install);

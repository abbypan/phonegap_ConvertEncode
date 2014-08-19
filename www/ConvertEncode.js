function ConvertEncode() {
}

ConvertEncode.prototype.from_to = 
function (src, from_enc, to_enc, succ_cb, err_cb) {
  cordova.exec(succ_cb, err_cb, "ConvertEncode", "from_to", [src,from_enc,to_enc]);
};

ConvertEncode.install = function () {
  if (!window.plugins) {
    window.plugins = {};
  }

  window.plugins.ConvertEncode = new ConvertEncode();
  return window.plugins.ConvertEncode;
};

cordova.addConstructor(ConvertEncode.install);

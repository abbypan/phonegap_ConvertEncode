//app.initialize();

function from_to(src, from_enc, to_enc) {
    cordova.exec(
            function(succ_d) { return succ_d; }, 
            function(err_d) { return err_d; }, 
            "ConvertEncode", "from_to", [src,from_enc,to_enc]);
};

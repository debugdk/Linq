//http://gd.geobytes.com/GetCityDetails
function geobytes() {
    $.getJSON('http://gd.geobytes.com/GetCityDetails?callback=?', function (data) {
        $("#geobytes").html("IP: " + data.geobytesremoteip + "<br>Country: " + data.geobytescountry + "<br>Code: " + data.geobytesinternet);
    });
}
//https://json.geoiplookup.io/api
function geoiplookup() {
    $.getJSON('https://json.geoiplookup.io/api?callback=?', function (data) {
        $("#geoiplookup").html("IP: " + data.ip + "<br>Country: " + data.country_name + "<br>Code: " + data.country_code);
    });
}
//http://www.geoplugin.net/json.gp?jsoncallback=?
function geoplugin() {
    $.getJSON('http://www.geoplugin.net/json.gp?jsoncallback=?', function (data) {
        $("#geoplugin").html("IP: " + data.geoplugin_request + "<br>Country: " + data.geoplugin_countryName + "<br>Code: " + data.geoplugin_countryCode);
    });
}
//https://ipapi.co/json/
function ipapi() {
    $.getJSON('https://ipapi.co/json/', function (data) {
        $("#ipapi").html("IP: " + data.ip + "<br>Country: " + data.country_name + "<br>Code: " + data.country);
    });
}
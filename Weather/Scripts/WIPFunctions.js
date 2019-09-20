var global_postcode;

function GUnload() { }
function Gload() {
}

function ftn_findlatlngfrompc(zipcode, callbackFunction) {
    if (zipcode != "") {

        $.ajax({
            url: 'https://api.promaptools.com/service/us/zip-lat-lng/get/?zip=' + zipcode + '&key=' + FMTkey,
            type: "GET",
            dataType: 'JSON',
            success: function (result) {

                if (result.status == "-3") {
                    //No results
                    console.log("Geocode was not successful (" + zipcode + ")(-3)");
                }
                else if (result.status == "1") {
                    callbackFunction(result.output[0], zipcode);
                    global_postcode = zipcode;
                }
                else {
                    console.log("Geocode was not successful for the following reason: " + result.msg);
                }

            },
            error: function (x, y, z) {
                alert(y);
            }
        });

    }
}

function PointFound(point, zipcode) {
    document.getElementById("message").innerHTML = "<p>The Latitude, Longitude of " + zipcode + " is:</p><strong>" + Number(point.latitude).toFixed(5) + "," + Number(point.longitude).toFixed(5) + "</strong>";
}
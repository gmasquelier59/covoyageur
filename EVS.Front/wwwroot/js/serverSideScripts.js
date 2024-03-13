function initAutocomplete() {

    var autocompleteFields = document.querySelectorAll("input[data-google-autocomplete=\"true\"]");

    autocompleteFields.forEach(function (autocompleteField) {

        var autocomplete = new google.maps.places.Autocomplete(autocompleteField, {
            componentRestrictions: { country: ["fr"] },
            fields: ["address_components", "geometry"],
            types: ["locality"],
        });
        autocomplete.htmlField = autocompleteField;

        autocomplete.addListener("place_changed", function () {
            const place = autocomplete.getPlace();
            const city = place.address_components[0].long_name;
            const latitude = place.geometry.location.lat();
            const longitude = place.geometry.location.lng();
            const fieldValue = city + "|" + latitude + "|" + longitude
            const hiddenhtmlField = document.querySelector("." + autocomplete.htmlField.getAttribute("data-value-field") + " input");
            hiddenhtmlField.value = fieldValue;
            var event = new Event('input');
            hiddenhtmlField.dispatchEvent(event);
        });
    });
}
(function ($) {
    "use strict"; // Start of use strict


    var slider = document.getElementById("wb-range");
    if (slider !== null) {
        var output = document.getElementById("wb-input");
        var status = document.getElementById("wb-status-text");

        output.innerHTML = slider.value;

        document.getElementById("RecordDate").valueAsDate = new Date()
       
        // Update the current slider value (each time you drag the slider handle)
        slider.oninput = function () {
            var slideValue = this.value;
            output.value = slideValue;

            console.log(slideValue);

            if (slideValue == 0) {
                status.textContent = "Terrible";
                slider.dataset.status = "0";
            } else if (slideValue == 20) {
                status.textContent = "Uneasy";
                slider.dataset.status = "1";
            } else if (slideValue == 40) {
                status.textContent = "Marginal";
                slider.dataset.status = "2";
            } else if (slideValue == 60) {
                status.textContent = "Okay";
                slider.dataset.status = "3";
            } else if (slideValue == 80) {
                status.textContent = "Well";
                slider.dataset.status = "4";
            } else {
                status.textContent = "Incredible";
                slider.dataset.status = "5";
            }

        }
    }


    jQuery(document).ready(function () {
        jQuery("time.timeago").timeago();
    });
    
    

})(jQuery); // End of use strict
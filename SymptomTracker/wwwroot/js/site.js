(function ($) {
    "use strict"; // Start of use strict

    function setCharAt(str, index, chr) {
        if (index > str.length - 1) return str;
        return str.substr(0, index) + chr + str.substr(index + 1);
    }

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


        $("#CG-SL input[type='checkbox']").change(function () {

            var symptomString = "00000000";


            $("#CG-SL input[type='checkbox']").each(function (index) {
            
                if (this.checked) {
                    if (index != 7) {
                        symptomString = setCharAt(symptomString, index, "1")
                    } else {
                        console.log("none of the above");
                        symptomString = "00000001";
            
                        $("#CG-SL input[type='checkbox']").each(function (index) {
                            if (index == 7) {
                                $(this).prop('checked', true);
                            } else {
                                $(this).prop('checked', false);
                            }
                        });
                    }
                }
            
            }).promise().done(function () { $("#sl-input").val(symptomString); });

        });
    });

    
    

})(jQuery); // End of use strict
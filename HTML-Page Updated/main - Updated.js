$(function () {
    $("#fileupload").change(function (event) {
        var x = URL.createObjectURL(event.target.files[0]);
        $("#profile-image").attr("src", x);
    });
})

$(function getUsersFullName() {
    $("#user-input-Name").keypress(function (e) {
        if (e.which == 13) {
            if ($('#header-div1-name #header-h1').length == 0) {
                var nameField = "<h1 id=\"header-h1\" style=\"padding-top:35px; margin: 0px; font-family: Times New Roman \"></h1>"
                $("#header-div1-name").append(nameField);
            }
            $("#header-h1").html($("#user-input-Name").val());
            $("#footer-span1").html($("#user-input-Name").val() + ", Confidential Resume");
            $("#user-input-Name").attr("style", "float: right").hide();
        }
    }).focusout(function () {
        if ($('#header-div1-name #header-h1').length == 0) {
            var nameField = "<h1 id=\"header-h1\" style=\"padding-top:35px; margin: 0px; font-family: Times New Roman \"></h1>"
            $("#header-div1-name").append(nameField);
        }
        $("#header-h1").html($("#user-input-Name").val());
        $("#footer-span1").html($("#user-input-Name").val() + ", Confidential Resume");
        $("#user-input-Name").attr("style", "float: right").hide();
    });
});

$(function getUsersJobPostion() {
    $("#user-input-position").on('keypress', (function (e) {
        if (e.which == 13) {
            if ($('#header-div1-position #header-h3').length == 0) {
                var jobField = "<h3 id=\"header-h3\" style=\"margin:0px; font-family: Times New Roman \"></h3>"
                $("#header-div1-position").append(jobField);
            }
            $("#header-h3").html($("#user-input-position").val());
            $("#user-input-position").attr("style", "float: right").hide();
        }
    }));
});

$(function getUsersFullAdress() {
    $("#user-input-adress").on('keypress', (function (e) {
        if (e.which == 13) {
            if ($('#header-div1-address #div1-address').length == 0) {
                var adressField = "<div id=\"div1-address\"></div>"
                $("#header-div1-address").append(adressField);
            }
            $("#div1-address").html($("#user-input-adress").val());
            $("#user-input-adress").attr("style", "float: right").hide();
        }
    }));
});

$(function getUsersContacts() {
    $("#user-input-contacts").on('keypress', (function (e) {
        if (e.which == 13) {
            if ($('#header-div1-contacts #div1-contacts').length == 0) {
                var contactsField = "<div id=\"div1-contacts\"></div>"
                $("#header-div1-contacts").append(contactsField);
            }
            $("#div1-contacts").html($("#user-input-contacts").val());
            $("#user-input-contacts").attr("style", "float: right").hide();
        }
    }));
});

$(function addSkill() {
    $("#user-input-skills").on('keypress', (function (e) {
        if (e.which == 13) {
            var listField = "<li class=\"skill-list\" style=\"padding-bottom: 10px\"></li>"
            $("#list-skill-general").append(listField);
            $("#list-skill-general li:last-child").html($("#user-input-skills").val());
        }
    }));
});

$(function addLanguage() {
    $("#user-input-languages").on('keypress', (function (e) {
        if (e.which == 13) {
            var listField = "<li class=\"language-list\" style=\"padding-bottom: 10px\"></li>"
            $("#list-skill-languages").append(listField);
            $("#list-skill-languages li:last-child").html($("#user-input-languages").val());
        }
    }));
});

$(function getUsersProfileInfo() {
    $("#submit-profile-info").click(function () {
        $("#profile-info-p1").html($("#user-input-profile").val());
        $("#main-div2-profile").remove();
    })
});

$(function getRidOfInputs() {
    $("#footer-button1").click(function () {
        $(".user-input").remove();
    })
})

$(function editHeaderInputs() {
    $("#header-edit-button").click(function () {
        $(".user-input").show();
    })
})

var incrementer = 1;
$(function getUsersWorkPlaceTime() {
    $("#user-input-work").on('keypress', (function (e) {
        if (e.which == 13) {
            var inputField = "<h4 id=\"h4-work" + (incrementer) + "\" style=\"font-family: Times New Roman \"></h4>"
            var listResposibilities = "<ul id=\"main-list-work-info" + (incrementer) + "\" style=\"list-style-type:square; padding: 0px 0px 0px 10px\"></ul>"
            $("#main-div2-work").append(inputField);
            $("#h4-work" + (incrementer)).html($("#user-input-work").val());
            $("#main-div2-work").append(listResposibilities);
            $("#hidden-input").show();
            $("#div-input-work").hide();
        }
    }));
});

$(function submitWorkResponsibility() {
    $("#user-input-responsibility-item").keypress(function (e) {
        if (e.which == 13) {
            var listField = "<li class=\"work-list\" style=\"padding-bottom: 10px\"></li>"
            $("#main-list-work-info" + (incrementer)).append(listField);
            $(".work-list").last().html($("#user-input-responsibility-item").val());
        }
    });
});

$(function submitWorkItemWithResponsibilities() {
    $("#submit-this-work").click(function () {
        $("#hidden-input").hide();
        $("#div-input-work").show();
        incrementer++;
    })
})





















// var mainArr = ["Main BODY elements: "];
// var subArr = [];
// var idArr = [];
// var map1 = new Map();

// function logSomething() {
//     console.log("Some elements are cleared!!!!!!!!")
//     document.getElementById("countOFBodyElements").innerHTML = null
//     document.getElementById("subElementsList").innerHTML = null
//     document.getElementById("infoAboutElems").innerHTML = null
//     mainArr.length = 0;
// }

// function showMainHtmlElements(parent) {
//     var c = document.getElementsByTagName(parent)[0].children;
//     var i;
//     for (i = 0; i < c.length; i++) {
//         mainArr.push(c[i].tagName)
//         document.getElementById("countOFBodyElements").innerHTML = mainArr.join(" - > ");
//         if (c[i].hasAttribute("id")) {
//             showChildHtmlElements(c[i].id);
//         }
//     }
// }

// function showChildHtmlElements(id) {
//     var c = document.getElementById(id).children;
//     var i;
//     for (i = 0; i < c.length; i++) {
//         if (c[i].hasAttribute("id")) {
//             subArr.push(c[i].tagName)
//             idArr.push(c[i].id)
//             var node = document.createElement("LI");
//             var textnode = document.createTextNode(c[i].id)
//             node.appendChild(textnode);
//             document.getElementById("subElementsList").appendChild(node);
//             showChildHtmlElements(c[i].id);
//         }
//     }
// }
// var maxUsedKey;
// function showInfoAboutElements(elementName) {
//     for (var elem of subArr) {
//         if (map1.has(elem)) {
//             map1.set(elem, map1.get(elem) + 1)
//         } else {
//             map1.set(elem, 1)
//         }
//     }

//     for (var entry of map1) {
//         var node = document.createElement("LI");
//         var textnode = document.createTextNode(entry)
//         node.appendChild(textnode);
//         document.getElementById("infoAboutElems").appendChild(node);
//     }

//     var someArr = map1.values();
//     var max = Math.max(...someArr);
//     for (let [key, value] of map1.entries()) {
//         if (value === max) {
//             maxUsedKey = key;
//         }
//     }
//     document.getElementById("mostUsedElem").innerHTML =
//         ("Most used elem : " + maxUsedKey);

//     var mostClassesElem;
//     var attributeCount = 1;
//     for (var elem of idArr) {
//         var elemAttributesCount =
//             document.getElementById(elem).classList.length;
//         if (elemAttributesCount > attributeCount) {
//             mostClassesElem = document.getElementById(elem);
//         }
//     }
//     document.getElementById("elemWithMostClasses").innerHTML =
//         ("Most classes has : id= \"" + mostClassesElem.id
//             + "\" in tag " + mostClassesElem.tagName);
//     subArr.length = 0;
//     map1.clear();
// }

var mainArr = ["Main BODY elements: "];
var subArr = [];
var idArr = [];
var map1 = new Map();

function logSomething() {
    console.log("Some elements are cleared!")
    document.getElementById("countOFBodyElements").innerHTML = null
    document.getElementById("subElementsList").innerHTML = null
    document.getElementById("infoAboutElems").innerHTML = null
    mainArr.length = 0;
}


function showMainHtmlElements(parent) {
    var c = document.getElementsByTagName(parent)[0].children;
    var i;
    for (i = 0; i < c.length; i++) {
        mainArr.push(c[i].tagName)
        document.getElementById("countOFBodyElements").innerHTML = mainArr.join(" - > ");
        if (c[i].hasAttribute("id")) {
            showChildHtmlElements(c[i].id);
        }
    }
}

function showChildHtmlElements(id) {
    var c = document.getElementById(id).children;
    var i;
    for (i = 0; i < c.length; i++) {
        if (c[i].hasAttribute("id")) {
            subArr.push(c[i].tagName)
            idArr.push(c[i].id)
            var node = document.createElement("LI");
            var textnode = document.createTextNode(c[i].id)
            node.appendChild(textnode);
            document.getElementById("subElementsList").appendChild(node);
            showChildHtmlElements(c[i].id);
        }
    }
}
var maxUsedKey;
function showInfoAboutElements(elementName) {
    for (var elem of subArr) {
        if (map1.has(elem)) {
            map1.set(elem, map1.get(elem) + 1)
        } else {
            map1.set(elem, 1)
        }
    }

    for (var entry of map1) {
        var node = document.createElement("LI");
        var textnode = document.createTextNode(entry)
        node.appendChild(textnode);
        document.getElementById("infoAboutElems").appendChild(node);
    }

    var someArr = map1.values();
    var max = Math.max(...someArr);
    for (let [key, value] of map1.entries()) {
        if (value === max) {
            maxUsedKey = key;
        }
    }
    document.getElementById("mostUsedElem").innerHTML =
        ("Most used elem : " + maxUsedKey);

    var mostClassesElem;
    var attributeCount = 1;
    for (var elem of idArr) {
        var elemAttributesCount =
            document.getElementById(elem).classList.length;
        if (elemAttributesCount > attributeCount) {
            mostClassesElem = document.getElementById(elem);
        }
    }
    document.getElementById("elemWithMostClasses").innerHTML =
        ("Most classes has : id= \"" + mostClassesElem.id
            + "\" in tag " + mostClassesElem.tagName);
    subArr.length = 0;
    map1.clear();
}



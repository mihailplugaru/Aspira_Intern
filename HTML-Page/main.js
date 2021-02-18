function logSomething() {
    console.log("Something displayed! Yey!")
}

function CreateNewElement() {
    var btn = document.createElement("P");
    btn.innerHTML = 'New Button'
    document.body.appendChild(btn);
}
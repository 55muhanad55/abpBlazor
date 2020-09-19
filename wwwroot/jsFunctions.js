/* window.SessionJsFunctions = {
    acceptMessage: function (cookieString) {
        document.cookie = cookieString;
    },
    getCookieValue: function (cookieName) {
        var value = document.cookie.match('(^|;)\\s*' + cookieName + '\\s*=\\s*([^;]+)');
        return value ? value.pop() : '';
    }
}; */


window.SessionJsFunctions = {
    setCookie: function (name, value, days) {
        var expires = "";
        if (days) {
            var date = new Date();
            date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
            expires = "; expires=" + date.toUTCString();
        }
        document.cookie = name + "=" + (value || "") + expires + "; path=/";
    },
    getCookieValue: function (name) {
        var nameEQ = name + "=";
        var ca = document.cookie.split(';');
        for (var i = 0; i < ca.length; i++) {
            var c = ca[i];
            while (c.charAt(0) == ' ') c = c.substring(1, c.length);
            if (c.indexOf(nameEQ) == 0) { console.log(c.substring(nameEQ.length, c.length)); return c.substring(nameEQ.length, c.length); }
        }
        return null;
    }, ref: function () {
        location.reload();
        return null;
    }

};
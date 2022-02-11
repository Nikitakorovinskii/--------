//import {createApp} from 'vue';
var app = Vue.createApp({});
app.component("name", {
    data: function () {
        return {
            firstName: 'Nikita',
            lastName: 'Korovinskii',
            middleName: 'Sergeevich'
        };
    },
    template: '<div>{{lastName}} {{firstName}} {{middleName}}</div>'
});
app.mount("#app");

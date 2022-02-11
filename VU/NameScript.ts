declare var Vue:any;
//import {createApp} from 'vue';

const app = Vue.createApp({});
app.component("name",{
    data() {
        return {
            firstName: 'Nikita',
            lastName: 'Korovinskii',
            middleName: 'Sergeevich'
        }
    },
    template:'<div>{{lastName}} {{firstName}} {{middleName}}</div>',
});
app.mount("#app");
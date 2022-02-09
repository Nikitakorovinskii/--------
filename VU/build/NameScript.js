const App = Vue.createApp({
    data() {
        return {
            firstName: 'Nikita',
            lastName: 'Korovinskii',
            middleName: 'Sergeevich'
        };
    }
});
// Registering and mounting our app
App.mount('#app');
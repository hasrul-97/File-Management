<template>
  <div id="app">
    <Header />
    <div id="body">
      <BreadCrumb :pages="x" class="mt-2 d-flex justify-content-start ml-3" />
      <router-view></router-view>
    </div>
  </div>
</template>

<script>
//  COMPONENTS IMPORT
import Header from "./components/Header.vue";
import BreadCrumb from "./components/BreadCrumb.vue";
import Window from "./components/Window.vue";

//  IMPORTS FOR VUE AND VUE-ROUTER
import VueRouter from "vue-router";
import Vue from "vue";

//  FOR BOOTSTRAP
import { BootstrapVue } from "bootstrap-vue";
Vue.use(BootstrapVue);
import "bootstrap/dist/css/bootstrap.css";
import "bootstrap-vue/dist/bootstrap-vue.css";

//  FOR ADAL
import Adal from "vue-adal";
import { AuthenticationContext } from "vue-adal"; // This will be populated with a valid context after initialization

Vue.use(Adal, {
  config: {
    //  TENANT ID
    tenant: "kumarpersonal.onmicrosoft.com",
    //  CLIENT ID
    clientId: "441b021e-e31c-4e72-9bba-98a893e1e881",
    //  REDIRECT URI
    // redirectUri: "https://www.mindtree.com",
    //  CACHE LOCATION(AVOID localStorage)
    cacheLocation: "sessionStorage",
  },
  // Set this to true for authentication on startup
  requireAuthOnInitialize: true,
});

//  TO INSRTUCT VUE INSTANCE TO USE VUE-ROUTER
Vue.use(VueRouter);

//  ROUTE PATH FOR COMPONENTS
const routes = [{ path: "/", component: Window }];

//  INITIALISE VUE-ROUTER WITH THE ROUTE PATHS
const router = new VueRouter({
  routes,
});

export default {
  name: "App",
  components: {
    Header,
    BreadCrumb,
  },
  data: function () {
    return { x: ["one", "two"], bal: "hi" };
  },
  created: function () {
    const profile = AuthenticationContext.user.profile;
    fetch(
      "https://localhost:44356/api/Opportunity/GetAllOpportunityForRG?userMID=" +
        profile.email.split("@")[0] +
        "&year=2020&rgName=CTO"
    )
        .then((res) => res.json())
      .then((data) => {
        console.log(data);
      });
    setTimeout(() => {
      this.x.push("three");
    }, 5000);
  },
  router: router,
};
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
</style>
<template>
  <v-app>
    <v-navigation-drawer
      persistent
      :mini-variant="miniVariant"
      :clipped="clipped"
      v-model="drawer"
      enable-resize-watcher
      fixed
      app
    >
      <v-list>
        <v-list-item value="true" v-for="(item, i) in items" :key="i" :to="item.link">
          <v-list-item-action>
            <v-icon v-html="item.icon"></v-icon>
          </v-list-item-action>
          <v-list-item-content>
            <v-list-item-title v-text="item.title"></v-list-item-title>
          </v-list-item-content>
        </v-list-item>
      </v-list>
    </v-navigation-drawer>

    <v-app-bar app :clipped-left="clipped" color="info" dark>
      <v-app-bar-nav-icon @click.stop="drawer = !drawer"></v-app-bar-nav-icon>
      <v-btn class="d-none d-lg-flex" icon @click.stop="miniVariant = !miniVariant">
        <v-icon v-html="miniVariant ? 'chevron_right' : 'chevron_left'"></v-icon>
      </v-btn>
      <v-btn class="d-none d-lg-flex" icon @click.stop="clipped = !clipped">
        <v-icon>web</v-icon>
      </v-btn>
      <v-toolbar-title v-text="title"></v-toolbar-title>
      <v-spacer></v-spacer>
    </v-app-bar>

    <v-content>
      <router-view />
    </v-content>

    <v-footer app>
      <span>&nbsp;Software Ateliers&nbsp;&copy;&nbsp;2019</span>
    </v-footer>
  </v-app>
</template>

<script lang="ts">
import { mdiSettingsOutline } from "@mdi/js";
import HelloWorld from "@/components/HelloWorld.vue";
import { Component, Vue } from "vue-property-decorator";
import Navbar from "@/components/Navbar.vue";
import Vacation from "@/components/Vacation.vue";
import Kanban from "@/components/Kanban.vue";

@Component({
  components: { HelloWorld, Navbar, Kanban, Vacation }
})
export default class App extends Vue {
  private clipped: boolean = true;
  private drawer: boolean = true;
  private miniVariant: boolean = false;
  private right: boolean = true;
  private title: string = "ASP.NET Core Vue Starter";
  private items = [
    { title: "Home", icon: "home", link: "/" },
    { title: "Counter", icon: "touch_app", link: "/counter" },
    { title: "Fetch data", icon: "get_app", link: "/fetch-data" },
    { title: "Vacation", icon: "timer_off", link: "/vacation" },
    { title: "Kanban", icon: "toc", link: "/kanban" },
    { title: "Analytics", icon: "bar_chart", link: "/analytics" },
    { title: "Settings", icon: "settings", link: "/settings" }
  ];
}
</script>

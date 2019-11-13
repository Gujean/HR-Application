<template>
  <div>
    <v-container fluid style="padding:50px;">
      <v-layout row wrap>
        <div v-for="TaskType in TaskTypes" :key="TaskType.name">
          <h1>{{TaskType.name}}</h1>
          <v-card
            style="width:300px; min-height:400px; max-height:500px; overflow-y:auto; margin-left:3px; margin-right:5px;"
          >
            <v-card-title>
              <v-sheet class="theme--light">
                <!--v-scroll-y-transition></v-scroll-y-transition-->
                <v-title>{{TaskType.title}}</v-title>
                <v-card-subtitle>{{TaskType.subtitle}}</v-card-subtitle>
                <v-card>
                  <v-card-text>{{TaskType.text}}</v-card-text>
                </v-card>
              </v-sheet>
            </v-card-title>
          </v-card>
        </div>
      </v-layout>
    </v-container>
  </div>
</template> 

<script lang="ts">
import { Action, Getter } from "vuex-class";
import { Component, Vue, Watch } from "vue-property-decorator";
import { watch } from "fs";
const namespace: string = "counter";

@Component
export default class Kanban extends Vue {
  TaskTypes = [
    {
      name: "New",
      title: "dasd",
      subtitle: "sgag",
      text:
        "gasgasfdgfdhdgfjgdjfgkdflgllllllllllllfgnasfognasfgnsanglkasnglasdngasdngnsadglknsd"
    },
    {
      name: "Active",
      title: "dasd",
      subtitle: "sgag",
      text: "gasgas"
    },
    {
      name: "Stuck",
      title: "dasd",
      subtitle: "sgag",
      text: "gasgas"
    },
    {
      name: "Resolved",
      title: "dasd",
      subtitle: "sgag",
      text: "gasgas"
    },
    {
      name: "Requires Updates",
      title: "dasd",
      subtitle: "sgag",
      text: "gasgas"
    }
  ];
}
</script>

<style lang="scss">
</style>

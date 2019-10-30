<template>
  <div>
    <v-sheet height="88vh">
      <v-calendar type="month" now="2019-01-08" value="2019-01-08" :events="events"></v-calendar>
    </v-sheet>
  </div>
</template>

<script lang="ts">
import { Component, Vue, Watch } from "vue-property-decorator";
import { watch } from "fs";

@Component
export default class Vacation extends Vue {
  events = [
    {
      name: "Vacation",
      start: "2018-12-30",
      end: "2019-01-02"
    },
    {
      name: "Meeting",
      start: "2019-01-07"
    },
    {
      name: "30th Birthday",
      start: "2019-01-03"
    },
    {
      name: "New Year",
      start: "2019-01-01"
    },
    {
      name: "Conference",
      start: "2019-01-21"
    },
    {
      name: "Hackathon",
      start: "2019-01-30",
      end: "2019-02-01"
    }
  ];
}
</script>

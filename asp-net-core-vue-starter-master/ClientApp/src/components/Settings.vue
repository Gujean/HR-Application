<template>
  <v-container fluid>
    <h1>This is the Settings Component</h1>
    <v-btn class="outlined" v-on:click="ChangeTheme()">Change Theme</v-btn>
  </v-container>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";

@Component
export default class Settings extends Vue {
  
}
</script>

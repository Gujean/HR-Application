<template>
  <div>
    <p>
      Current count (Vuex):
      <strong>{{ currentCount }}</strong>
    </p>
    <p>
      Current Name (Vuex) is {{currentName}}
      <input type="text" v-model="currentName" />
    </p>
    <v-btn class="ma-2" color="info" @click.prevent="increment">Increment</v-btn>
    <v-btn class="ma-2" color="info" @click.prevent="reset">Reset</v-btn>
  </div>
</template>

<script lang="ts">
import { Action, Getter } from "vuex-class";
import { Component, Vue, Watch } from "vue-property-decorator";
import { watch } from "fs";
const namespace: string = "counter";

@Component
export default class Counter extends Vue {
  @Getter("currentCount", { namespace })
  private currentCount!: number;
  @Getter("currentName", { namespace })
  private currentName!: string;
  @Action("increment", { namespace })
  private incrementCounter: any;
  @Action("reset", { namespace })
  private resetCounter: any;
  // @Action("modifyName", { namespace })
  // private modify: any;

  // @Watch("currentName")
  // modify() {
  //   this.modifyName();
  // }

  private increment() {
    this.incrementCounter();
  }
  private reset() {
    this.resetCounter();
  }
}
</script>

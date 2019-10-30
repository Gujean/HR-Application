export interface Task {
    id: number;
    name: string;
    details: string;
    priority: number; //1-10 10 is the task with the highest priority
    type: string; //bug, feature, hotfix
    state: string; //done, working on it, stuck, test
    userId: number;

    // constructor(id: number, name: string, details: string, priority: number, type: string, state: string, userId: number) {
    //   this.id = id;
    //   this.name = name;
    //   this.details = details;
    //   this.priority = priority;
    //   this.type = type;
    //   this.state = state;
    //   this.userId = userId;
}

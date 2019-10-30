export interface User {
    id: number;
    name: string;
    email: string;
    role: string; //Developer, QA Tester, Project Manager, Team Lead, HR
    projectId: number;
    vacantionDays: number;
    medicalDays: number;
    notPaidDays: number;
    isAdmin: boolean;
}
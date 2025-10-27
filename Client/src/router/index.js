import { createRouter, createWebHistory } from 'vue-router'

import HomeView from '../views/home-view.vue'
import AboutView from '../views/about-view.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    { path: '/', component: HomeView },
    { path: '/about', component: AboutView },
  ],
})

export default router

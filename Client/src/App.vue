<template>
  <nav class="navigation" role="navigation" aria-label="Main">
    <RouterLink to="/" class="nav-btn">Home</RouterLink>
    <RouterLink to="/about" class="nav-btn">About</RouterLink>
    <RouterLink to="/add" class="nav-btn">Add Recipe</RouterLink>
  </nav>
  <main class="center">
    <RouterView />
  </main>
</template>

<style>
.navigation {
  background: var(--color-primary);
  padding: 0.5rem 1rem;
  display: flex;
  gap: 0.5rem;
  align-items: center;
}

.navigation a {
  color: #fff;
  text-decoration: none;
  font-weight: 600;
}

.nav-btn {
  padding: 0.45rem 0.8rem;
  border-radius: 0.375rem;
  transition: background-color 120ms ease-in-out;
}
.nav-btn:hover { background-color: rgba(255,255,255,0.12); }

.navigation .router-link-active {
  background-color: rgba(255,255,255,0.2);
}

html, body, #app { height: 100%; }
.center {
  min-height: calc(100dvh - 56px);
  width: 80%;
  max-width: 1500px;
  margin-inline: auto;
  padding: 1rem;
  display: block;
}
</style>

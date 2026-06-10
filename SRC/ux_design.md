# UX Specification — Horror Podcast App

## Design Direction

### Theme
- **Horror-Elegant Dark Theme** (default) with optional Light Mode toggle
- Dark backgrounds: `#0A0A0A` (base), `#121212` (surface), `#1A1A1A` (card), `#242424` (elevated)
- Light backgrounds: `#F5F0EB` (base), `#FFFFFF` (surface), `#F0EAE4` (card)

### Color Palette
- **Primary**: Blood Crimson `#DC2626`
- **Accent**: Phantom Purple `#7C3AED`
- Gradient buttons: `['#DC2626', '#7C3AED']`
- Secondary text dark: `#9CA3AF`, light: `#6B7280`
- Body text dark: `#E5E7EB`, light: `#1F2937`
- Headings dark: `#FFFFFF`, light: `#0A0A0A`
- Error: `#EF4444`, Success: `#10B981`, Warning: `#F59E0B`
- Star rating: `#F59E0B`

### Typography (Google Fonts)
- **Display/Headings**: `Creepster` for app title/branding, `Outfit` (Bold/SemiBold) for section headings
- **Body**: `Outfit` (Regular/Medium)
- Scale: Display 32px → H1 24px → H2 20px → Body 16px → Caption 13px

### Backgrounds
- Dark mode: subtle radial gradient from `#1A0A0A` (dark red tint) center to `#0A0A0A` edges
- Cards: semi-transparent `rgba(26,26,26,0.85)` with subtle border `rgba(220,38,38,0.1)`
- Glass effects on player bar and modals

## Animation & Motion
- Screen transitions: horizontal slide for stack pushes, vertical slide for modals/bottom sheets
- Button press: scale 0.97 spring + haptic (light impact)
- List entry: staggered fade-in (50ms delay per item)
- Loading: skeleton shimmer with dark red tint
- Player mini-bar: slide-up entrance, smooth expand to full player
- Progress bar: animated fill with glow effect
- Favorite toggle: heart scale bounce animation
- Star rating: sequential scale-in on tap
- Respect reduced motion preferences

## Component Standards
- Buttons: gradient fill `[#DC2626, #7C3AED]`, rounded 12px, press animation, loading spinner state, disabled opacity 0.5
- Inputs: dark surface `#1A1A1A` bg, floating labels in `#9CA3AF`, focus border `#DC2626`, error shake + red border, rounded 12px
- Cards: rounded 16px, glass effect, subtle red-tinted border, press scale animation
- Images: `expo-image` with blurhash placeholders (dark reddish tones), fade-in on load
- Lists: `@shopify/flash-list`, staggered entry animation
- Empty states: themed illustration placeholder + descriptive text + action button
- Spacing: 8pt grid. Border radius: sm:8, md:12, lg:16, xl:24
- Accessibility: contrast ≥ 4.5:1, touch targets 44pt+, accessible labels

---

## File Structure

```
app/
  _layout.tsx              # Root layout: ThemeProvider, AuthProvider, PlayerProvider, font loading
  auth/
    _layout.tsx            # If authenticated → <Redirect href="/tabs/home" />; else <Stack>
    login.tsx
    signup.tsx
  tabs/
    _layout.tsx            # If !authenticated → <Redirect href="/auth/login" />; else <Tabs> with 4 tabs
    home.tsx               # Tab 1: Home / Discover
    search.tsx             # Tab 2: Search
    favorites.tsx          # Tab 3: Favorites
    profile.tsx            # Tab 4: Profile
  podcast/
    [podcastId]/
      index.tsx            # Podcast detail
  episode/
    [episodeId]/
      index.tsx            # Episode detail / comments
  player.tsx               # Full-screen player (modal presentation)
  edit-profile.tsx         # Edit profile screen
```

---

## Navigation

### Unauthenticated Flow
- `auth/_layout.tsx`: checks `isLoading` → splash; checks `isAuthenticated` → `<Redirect href="/tabs/home" />`; else renders `<Stack>` with login and signup
- **Login Screen** (`auth/login.tsx`): email + password form, "Sign Up" link pushes to signup
- **Signup Screen** (`auth/signup.tsx`): name + email + password form, "Log In" link pops back
- On successful login/signup: AuthProvider state updates; the layout switches to the authenticated tab group

### Authenticated Flow
- `tabs/_layout.tsx`: checks `isLoading` → splash; checks `!isAuthenticated` → `<Redirect href="/auth/login" />`; else renders `<Tabs>`
- **4 Tabs**: Home (skull icon), Search (magnifying glass), Favorites (heart), Profile (user)
- Stack pushes from tabs: tap podcast card → `podcast/[podcastId]`; tap episode → `episode/[episodeId]`
- Full player opens as modal: tap mini-player or "Play" button → `player.tsx`
- Edit profile: tap edit button on profile → `edit-profile.tsx`

### Persistent Mini-Player
- Rendered in root `_layout.tsx` (above tab bar) when a track is loaded in PlayerProvider
- Shows: episode thumbnail, title, play/pause button, progress bar
- Tap anywhere (except play/pause) → push to full player modal

---

## Screens

### 1. Login Screen (`auth/login.tsx`)
- **Purpose**: Authenticate existing users
- **Layout**: Centered content, app logo/title at top ("Creepster" font), dark gradient background
- **Elements**:
  - App logo: skull/ghost icon + "SINIESTRO" (or app name) in Creepster font, crimson color
  - Email input (floating label, keyboard type email)
  - Password input (floating label, secure entry, show/hide toggle)
  - "Iniciar Sesión" gradient button (full width)
  - "¿No tienes cuenta? Regístrate" text link → pushes signup screen
- **Validation**: email format, password min 6 chars, inline error messages with shake
- **Loading**: button shows spinner during API call
- **Error**: toast/snackbar for invalid credentials

### 2. Signup Screen (`auth/signup.tsx`)
- **Purpose**: Register new users
- **Layout**: Same style as login
- **Elements**:
  - App logo (smaller)
  - Name input
  - Email input
  - Password input (with strength indicator: weak/medium/strong)
  - Confirm password input
  - "Crear Cuenta" gradient button
  - "¿Ya tienes cuenta? Inicia Sesión" text link → pops back
- **Validation**: name required, email format, password min 6 chars, passwords match

### 3. Home Screen (`tabs/home.tsx`)
- **Purpose**: Discover and browse podcasts
- **Layout**: Scrollable vertical list with sections
- **Elements**:
  - Header: "Descubre" title + theme toggle icon button (sun/moon) in top-right
  - **Featured Section**: horizontal carousel of 3-5 featured podcasts, large cards (280x180) with cover image, gradient overlay, title, category badge. Auto-advances every 5s.
  - **Categorías**: horizontal scrollable chip/pill list of all categories. Tap filters the "Popular" section below.
  - **Populares**: vertical list of podcast cards. Each card shows: cover image (80x80 rounded 12), title, category badge, average rating (stars), episode count. Tap → push `podcast/[podcastId]`.
  - **Recientes**: horizontal scroll of recently added episodes. Small cards with thumbnail, episode title, podcast name, duration. Tap → push `episode/[episodeId]`.
- **Loading**: skeleton shimmer for each section
- **Pull-to-refresh**: refreshes all sections

### 4. Search Screen (`tabs/search.tsx`)
- **Purpose**: Search podcasts and episodes
- **Layout**: Search bar at top, results below
- **Elements**:
  - Search input with magnifying glass icon, clear button, auto-focus option
  - Category filter chips below search bar (horizontal scroll, multi-select)
  - Results split into two sections: "Podcasts" and "Episodios"
  - Podcast results: same card style as home
  - Episode results: thumbnail, title, podcast name, duration
  - Tap podcast → push `podcast/[podcastId]`; tap episode → push `episode/[episodeId]`
- **Empty state**: when no query, show trending/suggested categories as large tappable cards
- **No results**: ghost illustration + "No se encontraron resultados" message

### 5. Favorites Screen (`tabs/favorites.tsx`)
- **Purpose**: View saved/favorited podcasts
- **Layout**: Vertical list
- **Elements**:
  - Header: "Mis Favoritos" title
  - List of favorited podcasts: cover image, title, category, rating, heart icon (filled, tap to unfavorite with confirmation)
  - Swipe-to-remove gesture alternative
- **Empty state**: heart illustration + "Aún no tienes favoritos" + "Explorar" button → switches to Home tab
- **Loading**: skeleton list

### 6. Profile Screen (`tabs/profile.tsx`)
- **Purpose**: View/manage user profile and settings
- **Layout**: Profile header + settings list
- **Elements**:
  - Profile header: avatar image (circular 100px, tap to view large), name, email, bio
  - "Editar Perfil" outline button → push `edit-profile.tsx`
  - Stats row: "X Favoritos" | "X Comentarios" | "X Valoraciones"
  - Settings section:
    - Theme toggle: "Modo Oscuro" / "Modo Claro" switch
    - "Cerrar Sesión" button (red text, confirmation dialog)
  - App version at bottom
- **Logout**: confirmation dialog → on confirm, AuthProvider clears state; layout switches to auth

### 7. Edit Profile Screen (`edit-profile.tsx`)
- **Purpose**: Update profile information and photo
- **Layout**: Form screen with save button
- **Elements**:
  - Avatar: current photo with camera overlay icon. Tap → image picker (camera/gallery). Uploads via presigned URL flow.
  - Name input (pre-filled)
  - Bio textarea (pre-filled, max 200 chars, char counter)
  - "Guardar" gradient button
  - Back arrow in header
- **Validation**: name required
- **Loading**: button spinner during save

### 8. Podcast Detail Screen (`podcast/[podcastId]/index.tsx`)
- **Purpose**: View podcast info, episodes, rate, favorite
- **Layout**: Scrollable with hero header
- **Elements**:
  - Hero: cover image (full width, 250px height) with gradient overlay, parallax on scroll
  - Below hero: podcast title, author, category badge
  - Action row: Favorite heart toggle button (with count), Star rating display (average + count)
  - User rating: tap stars to rate (1-5), shows "Tu valoración" if already rated, tap to update
  - Description: expandable text (3 lines collapsed, "Ver más" to expand)
  - "Episodios" section header with episode count
  - Episode list: numbered list, each item shows: episode number, title, duration, publication date, play button icon. Tap row → push `episode/[episodeId]`. Tap play icon → starts playback immediately via PlayerProvider.
- **Loading**: skeleton with image placeholder

### 9. Episode Detail Screen (`episode/[episodeId]/index.tsx`)
- **Purpose**: View episode info, play, read/write comments
- **Layout**: Scrollable
- **Elements**:
  - Episode header: podcast cover image (small), podcast name (tappable → podcast detail), episode title, duration, publication date, play count
  - "Reproducir" gradient button (full width) → loads episode in PlayerProvider, opens full player
  - Description: full episode description text
  - **Comments section**:
    - Header: "Comentarios" + count
    - Comment input: text input + send button (gradient icon button)
    - Comment list: each shows user avatar, user name, comment text, timestamp (relative: "hace 2h"). Most recent first.
    - Own comments show delete icon (trash) with confirmation
- **Loading**: skeleton
- **Empty comments**: "Sé el primero en comentar" message

### 10. Full Player Screen (`player.tsx`)
- **Purpose**: Full audio playback controls
- **Layout**: Modal presentation, full screen
- **Elements**:
  - Down chevron button (top-left) to dismiss modal
  - Large cover image (centered, 300x300, rounded 20, shadow glow effect in crimson)
  - Episode title (scrolling marquee if long)
  - Podcast name (tappable → dismiss + push podcast detail)
  - Progress bar: interactive slider, current time / total time labels. Drag to seek.
  - Control row: shuffle (disabled/decorative), rewind 15s, play/pause (large, gradient circle), forward 30s, repeat toggle
  - Speed control: pill showing current speed (0.5x, 0.75x, 1x, 1.25x, 1.5x, 2x), tap cycles through
  - Bottom: share button (optional), episode info button → push episode detail
- **Background**: blurred cover image with dark overlay
- **Animation**: cover image subtle pulse on play, controls fade in

---

## State Management

### AuthProvider (Context)
- `user`, `isAuthenticated`, `isLoading`, `login()`, `signup()`, `logout()`
- Persists token in SecureStore / AsyncStorage

### ThemeProvider (Context)
- `isDarkMode`, `toggleTheme()`, `theme` object
- Persists preference in AsyncStorage

### PlayerProvider (Context)
- `currentEpisode`, `isPlaying`, `position`, `duration`, `playbackSpeed`
- `loadEpisode(episode)`, `play()`, `pause()`, `seekTo(ms)`, `skipForward(30s)`, `skipBackward(15s)`, `setSpeed(rate)`
- Saves/restores playback position per episode via API
- Uses `expo-av` Audio API
- Exposes `isPlayerVisible` (true when an episode is loaded) for mini-player rendering

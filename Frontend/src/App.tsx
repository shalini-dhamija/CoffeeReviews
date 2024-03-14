import { BrowserRouter as Router, Routes, Route } from 'react-router-dom'
import './App.css'
import Home from './pages/Home'
import AllVarieties from './pages/AllVarieties'
import AddVariety from './pages/AddVariety'

function App() {
  return (
    <Router>
      <Routes>
        <Route index element={<Home />} />
        <Route path="/varieties" element={<AllVarieties />} />
        <Route path="/varieties/add" element={<AddVariety />} />
        <Route path="/varieties/:slug" element={<h1>Variety</h1>} />
      </Routes>
    </Router>
  )
}

export default App

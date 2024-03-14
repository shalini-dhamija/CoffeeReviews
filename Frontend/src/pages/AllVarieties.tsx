import { useState, useEffect } from "react"
import Variety from "../models/Variety"
import { Link } from "react-router-dom"

function AllVarieties() {
  const [varieties, setVarieties] = useState<Variety[]>()
  const [loading, setLoading] = useState(true)
  const [error, setError] = useState(false)

  function loadVarieties() {
    fetch("http://localhost:5199/varieties")
      .then(response => response.json())
      .then(data => setVarieties(data))
      .catch(() => setError(true))
      .finally(() => setLoading(false))
  }

  useEffect(loadVarieties, [])

  return (
    <> 
      <h1>All Varieties</h1>
      {varieties && varieties.map(variety => 
        <p key={variety.slug}>
          <Link to={`/varieties/${variety.slug}`}>{variety.name}</Link>
        </p>
      )}
      {loading && <p>Loading...</p>}
      {error && <p>Error while loading</p>}
    </>
  )
}

export default AllVarieties
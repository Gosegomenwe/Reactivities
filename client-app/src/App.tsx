import { useEffect, useState } from 'react'
import axios from 'axios'
import './App.css'

function App() {
  // Fetch data from API
  const [activities, setActivities] = useState([]);

  useEffect(()=> {
    axios.get('http://127.0.0.1:5000/api/activities')
    .then(response => {
      setActivities(response.data)
    })
  }, []) //square brackets ensure that useEffects function is only called once


  return (
    <div className='Title'>
      <h1>Reactivity</h1>
      <ul>
        {activities.map((activity: any) => (
          <li key={activity.id}>
            {activity.title}
          </li>
        ))}
      </ul>
    </div>
  )
}

export default App

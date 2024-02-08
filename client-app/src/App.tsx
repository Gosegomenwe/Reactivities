import { useEffect, useState } from 'react'
import './App.css'
import axios from 'axios';
import { Header, List } from 'semantic-ui-react';

function App() {
  // Fetch data from API
  const [activities, setActivities] = useState([]);

  useEffect(() => {
    axios.get('http://127.0.0.1:5000/api/activities')
     .then(response => {
      setActivities(response.data)
    })
  }, []) //square brackets ensure that useEffects function is only called once


  return (
    <div className='Title'>
      <Header as='h2' icon='users' content='Reactivities' />
      <List>
        {activities.map((activity: any) => (
          <List.Item key={activity.id}>
            {activity.title}
          </List.Item>
        ))}
      </List>
    </div>
  )
}

export default App

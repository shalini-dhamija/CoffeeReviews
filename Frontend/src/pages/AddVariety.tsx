import { FormEvent } from "react"

function AddVariety() {

  function submitVariety(event: FormEvent<HTMLFormElement>) {
    event.preventDefault();
    var formData = new FormData(event.target as HTMLFormElement);
    fetch("http://localhost:5199/varieties", {
      method: "post",
      headers: {
        "Content-Type": "application/json"
      },
      body: JSON.stringify(Object.fromEntries(formData))
    }).then((response) => {
      if(response.ok){
        (event.target as HTMLFormElement).reset()
      }
    })
  }

  return (
    <> 
      <h1>Add Variety</h1>
      <form onSubmit={submitVariety} >
        <div>
          <label>
            Name: <input type="text" name="name" required />
          </label>
        </div>
        <div>
          <label>
            Bean Type: <select defaultValue={0} name="beanType" required>
              <option value={0}>Arabica</option>
              <option value={1}>Robusta</option>
              <option value={2}>Liberica</option>
              <option value={3}>Excelsa</option>
            </select>
          </label>
        </div>
        <div>
          <label>
            Region of Origin: <input type="text" name="regionOfOrigin" required />
          </label>
        </div>
        <div>
          <label>
            Description: <textarea rows={3} name="description" required />
          </label>
        </div>
        <button type="submit">Add Variety</button>
      </form>
    </>
  )
}

export default AddVariety
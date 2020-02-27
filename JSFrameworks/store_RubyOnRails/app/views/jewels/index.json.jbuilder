json.array!(@jewels) do |jewel|
  json.extract! jewel, :id, :name, :description, :price, :quantity, :collection_id
  json.url jewel_url(jewel, format: :json)
end

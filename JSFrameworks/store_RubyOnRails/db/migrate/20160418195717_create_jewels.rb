class CreateJewels < ActiveRecord::Migration
  def change
    create_table :jewels do |t|
      t.string :name
      t.text :description
      t.decimal :price
      t.integer :quantity
      t.references :collection, index: true, foreign_key: true

      t.timestamps null: false
    end
  end
end
